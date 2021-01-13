// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace MediaLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using MediaLibrary.Storage;
    using MediaLibrary.Storage.Search;
    using TaggingLibrary;

    public partial class EditTagsForm : Form
    {
        private readonly MediaIndex index;
        private readonly HashSet<string> rejectedTags = new HashSet<string>();
        private readonly IList<SearchResult> searchResults;
        private readonly Dictionary<string, TagControl> suggestionControls = new Dictionary<string, TagControl>();
        private readonly Dictionary<string, TagControl> tagControls = new Dictionary<string, TagControl>();
        private Dictionary<string, int> tagCounts;

        public EditTagsForm(MediaIndex index, IList<SearchResult> searchResults)
        {
            this.InitializeComponent();
            this.index = index;
            this.searchResults = searchResults;
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            var tag = this.tagCombo.Text.Trim();
            this.tagCombo.Text = string.Empty;
            this.tagCombo.Focus();

            if (string.IsNullOrWhiteSpace(tag))
            {
                return;
            }

            await this.AddTagAndUpdate(tag).ConfigureAwait(true);
        }

        private async Task AddTagAndUpdate(string tag)
        {
            if (this.tagControls.TryGetValue(tag, out var tagControl))
            {
                tagControl.Indeterminate = false;
            }
            else
            {
                tagControl = this.AddTagControl(tag, indeterminate: false);
            }

            foreach (var searchResult in this.searchResults)
            {
                await this.index.AddHashTag(new HashTag(searchResult.Hash, tag)).ConfigureAwait(true);
            }

            this.tagCounts[tag] = this.searchResults.Count;
            this.rejectedTags.Remove(tag);
            this.RefreshSuggestions();
            this.tagLayoutPanel.ScrollControlIntoView(tagControl);
        }

        private TagControl AddTagControl(string tag, bool indeterminate)
        {
            var tagControl = new TagControl { Text = tag, Tag = tag, Indeterminate = indeterminate };
            tagControl.DeleteClick += this.TagControl_DeleteClick;
            tagControl.ContextMenuStrip = this.tagContextMenu;
            this.existingTags.Controls.Add(this.tagControls[tag] = tagControl);
            return tagControl;
        }

        private void AddTagsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                this.Close();
            }
        }

        private Dictionary<string, int> CountTags()
        {
            var tagCounts = new Dictionary<string, int>();
            foreach (var tag in this.searchResults.SelectMany(r => r.Tags))
            {
                tagCounts[tag] = tagCounts.TryGetValue(tag, out var count) ? count + 1 : 1;
            }

            return tagCounts;
        }

        private async void EditTagsForm_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            await this.PopulateExistingTags().ConfigureAwait(true);
            this.PopulateTagsCombo();
            this.Enabled = true;
        }

        private TagControl GetOrUpdateSuggestionControl(string tag, bool isMissing, bool isInMissingGroups, IEnumerable<IList<TagRule>> rules)
        {
            var toolTip = string.Join(Environment.NewLine, rules.Select(r => string.Join(Environment.NewLine, r)));
            if (!this.suggestionControls.TryGetValue(tag, out var suggestionControl))
            {
                suggestionControl = new TagControl
                {
                    Text = tag,
                    Tag = toolTip,
                    Indeterminate = !isMissing, // TODO: Third state for !isInMissingGroups,
                    AllowDelete = true,
                    ContextMenuStrip = this.suggestionContextMenu,
                };
                suggestionControl.MouseClick += this.SuggestionControl_MouseClick;
                suggestionControl.DeleteClick += this.SuggestionControl_DeleteClick;
                suggestionControl.MouseEnter += this.SuggestionControl_MouseEnter;
                suggestionControl.MouseLeave += this.SuggestionControl_MouseLeave;
                suggestionControl.Cursor = Cursors.Hand;
                this.suggestionControls[tag] = suggestionControl;
            }
            else
            {
                suggestionControl.Indeterminate = !isMissing; // TODO: Third state for !isInMissingGroups,
                suggestionControl.Tag = toolTip;
            }

            return suggestionControl;
        }

        private async Task PopulateExistingTags()
        {
            this.tagCounts = this.CountTags();
            foreach (var tag in this.tagCounts)
            {
                this.AddTagControl(tag.Key, tag.Value != this.searchResults.Count);
            }

            foreach (var searchResult in this.searchResults)
            {
                this.rejectedTags.UnionWith(
                    (await this.index.GetRejectedTags(searchResult.Hash).ConfigureAwait(true)).Select(t => t.Tag));
            }

            this.RefreshSuggestions();
        }

        private async void PopulateTagsCombo()
        {
            var tagSet = new HashSet<string>(this.index.TagEngine.GetKnownTags());
            tagSet.UnionWith(await this.index.GetAllTags().ConfigureAwait(true));
            var text = this.tagCombo.Text;
            this.tagCombo.DataSource = tagSet.ToList();
            this.tagCombo.Text = text;
        }

        private void RefreshSuggestions()
        {
            this.suggestedTags.SuspendLayout();
            var threshold = this.searchResults.Count / 2 + 1;
            var result = this.index.TagEngine.Analyze(this.tagCounts.Where(t => t.Value >= threshold).Select(t => t.Key), this.rejectedTags);
            var allMissingTags = new HashSet<string>(result.MissingTagSets.SelectMany(t => t.Result));
            var missingTags = new HashSet<string>(result.MissingTagSets.Where(t => t.Result.Count == 1).SelectMany(t => t.Result));

            var rulesLookup = result.SuggestedTags.ToLookup(r => r.Result, r => r.Rules);
            var existing = new HashSet<Control>(this.suggestedTags.Controls.Cast<Control>());
            foreach (var c in existing)
            {
                if (!rulesLookup[c.Text].Any())
                {
                    this.suggestedTags.Controls.Remove(c);
                }
            }

            foreach (var g in rulesLookup)
            {
                var suggestion = g.Key;
                if (!this.rejectedTags.Contains(suggestion))
                {
                    var suggestionControl = this.GetOrUpdateSuggestionControl(suggestion, missingTags.Contains(suggestion), allMissingTags.Contains(suggestion), g);
                    if (!existing.Contains(suggestionControl))
                    {
                        this.suggestedTags.Controls.Add(suggestionControl);
                    }
                }
            }

            this.suggestedTags.ResumeLayout();
        }

        private void RejectSuggestionMenuItem_Click(object sender, EventArgs e)
        {
            var context = ((sender as ToolStripMenuItem)?.Owner as ContextMenuStrip)?.SourceControl;
            this.SuggestionControl_DeleteClick(context, e);
        }

        private async void RejectTagMenuItem_Click(object sender, EventArgs e)
        {
            var tagControl = (TagControl)((sender as ToolStripMenuItem)?.Owner as ContextMenuStrip)?.SourceControl;

            var tag = tagControl.Text;
            this.RemoveTagControl(tagControl, destroy: true);

            if (this.suggestionControls.TryGetValue(tag, out tagControl))
            {
                this.RemoveSuggestionControl(tagControl, destroy: true);
            }

            foreach (var searchResult in this.searchResults)
            {
                await this.index.RemoveHashTag(new HashTag(searchResult.Hash, tag), rejectTag: true).ConfigureAwait(true);
            }

            this.tagCounts.Remove(tag);
            this.rejectedTags.Add(tag);
            this.RefreshSuggestions();
        }

        private void RemoveSuggestionControl(TagControl tagControl, bool destroy = false)
        {
            this.suggestedTags.Controls.Remove(tagControl);
            if (destroy)
            {
                var tag = tagControl.Text;
                tagControl.MouseClick -= this.SuggestionControl_MouseClick;
                tagControl.DeleteClick -= this.SuggestionControl_DeleteClick;
                tagControl.MouseEnter -= this.SuggestionControl_MouseEnter;
                tagControl.MouseLeave -= this.SuggestionControl_MouseLeave;
                this.toolTip.Hide(this);
                this.suggestionControls.Remove(tag);
                this.toolTip.SetToolTip(tagControl, null);
                tagControl.Dispose();
            }
        }

        private void RemoveTagControl(TagControl tagControl, bool destroy)
        {
            this.existingTags.Controls.Remove(tagControl);
            if (destroy)
            {
                var tag = tagControl.Text;
                tagControl.DeleteClick -= this.TagControl_DeleteClick;
                this.tagControls.Remove(tag);
                tagControl.Dispose();
            }
        }

        private void RemoveTagMenuItem_Click(object sender, EventArgs e)
        {
            var context = ((sender as ToolStripMenuItem)?.Owner as ContextMenuStrip)?.SourceControl;
            this.TagControl_DeleteClick(context, e);
        }

        private async void SuggestionControl_DeleteClick(object sender, EventArgs e)
        {
            var tagControl = (TagControl)sender;
            var tag = tagControl.Text;
            this.RemoveSuggestionControl(tagControl, destroy: true);

            if (this.tagControls.TryGetValue(tag, out tagControl))
            {
                this.RemoveTagControl(tagControl, destroy: true);
            }

            foreach (var searchResult in this.searchResults)
            {
                await this.index.RemoveHashTag(new HashTag(searchResult.Hash, tag), rejectTag: true).ConfigureAwait(true);
            }

            this.tagCounts.Remove(tag);
            this.rejectedTags.Add(tag);
            this.RefreshSuggestions();
        }

        private async void SuggestionControl_MouseClick(object sender, MouseEventArgs e)
        {
            var tagControl = (TagControl)sender;
            var tag = tagControl.Text;
            this.RemoveSuggestionControl(tagControl);

            await this.AddTagAndUpdate(tag).ConfigureAwait(true);
        }

        private void SuggestionControl_MouseEnter(object sender, EventArgs e)
        {
            if (sender is TagControl tagControl)
            {
                if (tagControl.Tag is string toolTip)
                {
                    var location = tagControl.PointToScreen(new Point(0, tagControl.Height));
                    location.Offset(-this.Left, -this.Top + 1);
                    this.toolTip.Show(toolTip, this, location);
                }
                else
                {
                    this.toolTip.Hide(this);
                }
            }
        }

        private void SuggestionControl_MouseLeave(object sender, EventArgs e)
        {
            if (sender is TagControl tagControl)
            {
                var cursorPosition = Cursor.Position;
                var screenRectangle = tagControl.RectangleToScreen(new Rectangle(0, 0, tagControl.Width, tagControl.Height));
                if (!screenRectangle.Contains(cursorPosition))
                {
                    this.toolTip.Hide(this);
                }
            }
        }

        private async void TagControl_DeleteClick(object sender, EventArgs e)
        {
            var tagControl = (TagControl)sender;
            var tag = tagControl.Text;
            this.RemoveTagControl(tagControl, destroy: true);

            foreach (var searchResult in this.searchResults)
            {
                await this.index.RemoveHashTag(new HashTag(searchResult.Hash, tag)).ConfigureAwait(true);
            }

            this.tagCounts.Remove(tag);
            this.RefreshSuggestions();
        }
    }
}
