namespace MediaLibrary
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addIndexedFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.mainProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.playButton = new System.Windows.Forms.ToolStripButton();
            this.playAllButton = new System.Windows.Forms.ToolStripButton();
            this.shuffleAllButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.favoriteFilesDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.favoriteFilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.favoriteAudioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteImagesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteVideoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starredDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.starredFilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.starredAudioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starredImagesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starredVideoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.homeButton = new System.Windows.Forms.ToolStripButton();
            this.audioDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.allAudioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.audioFavoritesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioStarsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagesDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.allImagesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.imageFavoritesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageStarsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.allVideoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.videoFavoritesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoStarsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBox = new System.Windows.Forms.ToolStripTextBox();
            this.mainMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenu.Size = new System.Drawing.Size(800, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addIndexedFolderToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // addIndexedFolderToolStripMenuItem
            // 
            this.addIndexedFolderToolStripMenuItem.Name = "addIndexedFolderToolStripMenuItem";
            this.addIndexedFolderToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.addIndexedFolderToolStripMenuItem.Text = "Add Indexed Folder...";
            this.addIndexedFolderToolStripMenuItem.Click += new System.EventHandler(this.AddIndexedFolderToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.ShowItemToolTips = true;
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Maximum = 1000;
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playButton,
            this.playAllButton,
            this.shuffleAllButton,
            this.toolStripSeparator1,
            this.favoriteFilesDropDown,
            this.starredDropDown,
            this.toolStripSeparator2,
            this.homeButton,
            this.audioDropDown,
            this.imagesDropDown,
            this.videoDropDown,
            this.searchBox});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip";
            // 
            // playButton
            // 
            this.playButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playButton.Image = global::MediaLibrary.Properties.Resources.controls_play;
            this.playButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(23, 22);
            this.playButton.Text = "Play";
            // 
            // playAllButton
            // 
            this.playAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playAllButton.Image = global::MediaLibrary.Properties.Resources.controls_forward;
            this.playAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playAllButton.Name = "playAllButton";
            this.playAllButton.Size = new System.Drawing.Size(23, 22);
            this.playAllButton.Text = "Play all";
            // 
            // shuffleAllButton
            // 
            this.shuffleAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shuffleAllButton.Image = global::MediaLibrary.Properties.Resources.button_shuffle;
            this.shuffleAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.shuffleAllButton.Name = "shuffleAllButton";
            this.shuffleAllButton.Size = new System.Drawing.Size(23, 22);
            this.shuffleAllButton.Text = "Shuffle all";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // favoriteFilesDropDown
            // 
            this.favoriteFilesDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.favoriteFilesDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favoriteFilesMenuItem,
            this.toolStripSeparator4,
            this.favoriteAudioMenuItem,
            this.favoriteImagesMenuItem,
            this.favoriteVideoMenuItem});
            this.favoriteFilesDropDown.Image = global::MediaLibrary.Properties.Resources.love_it;
            this.favoriteFilesDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.favoriteFilesDropDown.Name = "favoriteFilesDropDown";
            this.favoriteFilesDropDown.Size = new System.Drawing.Size(29, 22);
            this.favoriteFilesDropDown.Text = "Favorites";
            // 
            // favoriteFilesMenuItem
            // 
            this.favoriteFilesMenuItem.Image = global::MediaLibrary.Properties.Resources.common_file_heart;
            this.favoriteFilesMenuItem.Name = "favoriteFilesMenuItem";
            this.favoriteFilesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.favoriteFilesMenuItem.Tag = "!favorite";
            this.favoriteFilesMenuItem.Text = "Files";
            this.favoriteFilesMenuItem.Click += new System.EventHandler(this.SearchBookmark_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // favoriteAudioMenuItem
            // 
            this.favoriteAudioMenuItem.Image = global::MediaLibrary.Properties.Resources.audio_file_heart;
            this.favoriteAudioMenuItem.Name = "favoriteAudioMenuItem";
            this.favoriteAudioMenuItem.Size = new System.Drawing.Size(180, 22);
            this.favoriteAudioMenuItem.Tag = "!favorite type:audio";
            this.favoriteAudioMenuItem.Text = "Audio";
            this.favoriteAudioMenuItem.Click += new System.EventHandler(this.SearchBookmark_Click);
            // 
            // favoriteImagesMenuItem
            // 
            this.favoriteImagesMenuItem.Image = global::MediaLibrary.Properties.Resources.image_file_heart;
            this.favoriteImagesMenuItem.Name = "favoriteImagesMenuItem";
            this.favoriteImagesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.favoriteImagesMenuItem.Tag = "!favorite type:image";
            this.favoriteImagesMenuItem.Text = "Images";
            this.favoriteImagesMenuItem.Click += new System.EventHandler(this.SearchBookmark_Click);
            // 
            // favoriteVideoMenuItem
            // 
            this.favoriteVideoMenuItem.Image = global::MediaLibrary.Properties.Resources.video_file_heart;
            this.favoriteVideoMenuItem.Name = "favoriteVideoMenuItem";
            this.favoriteVideoMenuItem.Size = new System.Drawing.Size(180, 22);
            this.favoriteVideoMenuItem.Tag = "!favorite type:video";
            this.favoriteVideoMenuItem.Text = "Video";
            this.favoriteVideoMenuItem.Click += new System.EventHandler(this.SearchBookmark_Click);
            // 
            // starredDropDown
            // 
            this.starredDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.starredDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.starredFilesMenuItem,
            this.toolStripSeparator3,
            this.starredAudioMenuItem,
            this.starredImagesMenuItem,
            this.starredVideoMenuItem});
            this.starredDropDown.Image = global::MediaLibrary.Properties.Resources.rating_star;
            this.starredDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.starredDropDown.Name = "starredDropDown";
            this.starredDropDown.Size = new System.Drawing.Size(29, 22);
            this.starredDropDown.Text = "Starred";
            // 
            // starredFilesMenuItem
            // 
            this.starredFilesMenuItem.Image = global::MediaLibrary.Properties.Resources.common_file_star;
            this.starredFilesMenuItem.Name = "starredFilesMenuItem";
            this.starredFilesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.starredFilesMenuItem.Tag = "stars:>=3";
            this.starredFilesMenuItem.Text = "Files";
            this.starredFilesMenuItem.Click += new System.EventHandler(this.SearchBookmark_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // starredAudioMenuItem
            // 
            this.starredAudioMenuItem.Image = global::MediaLibrary.Properties.Resources.audio_file_star;
            this.starredAudioMenuItem.Name = "starredAudioMenuItem";
            this.starredAudioMenuItem.Size = new System.Drawing.Size(180, 22);
            this.starredAudioMenuItem.Tag = "stars:>=3 type:audio";
            this.starredAudioMenuItem.Text = "Audio";
            this.starredAudioMenuItem.Click += new System.EventHandler(this.SearchBookmark_Click);
            // 
            // starredImagesMenuItem
            // 
            this.starredImagesMenuItem.Image = global::MediaLibrary.Properties.Resources.image_file_star;
            this.starredImagesMenuItem.Name = "starredImagesMenuItem";
            this.starredImagesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.starredImagesMenuItem.Tag = "stars:>=3 type:image";
            this.starredImagesMenuItem.Text = "Images";
            this.starredImagesMenuItem.Click += new System.EventHandler(this.SearchBookmark_Click);
            // 
            // starredVideoMenuItem
            // 
            this.starredVideoMenuItem.Image = global::MediaLibrary.Properties.Resources.video_file_star;
            this.starredVideoMenuItem.Name = "starredVideoMenuItem";
            this.starredVideoMenuItem.Size = new System.Drawing.Size(180, 22);
            this.starredVideoMenuItem.Tag = "stars:>=3 type:video";
            this.starredVideoMenuItem.Text = "Video";
            this.starredVideoMenuItem.Click += new System.EventHandler(this.SearchBookmark_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // homeButton
            // 
            this.homeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeButton.Image = global::MediaLibrary.Properties.Resources.house_2;
            this.homeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(23, 22);
            this.homeButton.Text = "Home";
            this.homeButton.Click += new System.EventHandler(this.SearchBookmark_Click);
            // 
            // audioDropDown
            // 
            this.audioDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.audioDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allAudioMenuItem,
            this.toolStripSeparator5,
            this.audioFavoritesMenuItem,
            this.audioStarsMenuItem});
            this.audioDropDown.Image = global::MediaLibrary.Properties.Resources.music_note_1;
            this.audioDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.audioDropDown.Name = "audioDropDown";
            this.audioDropDown.Size = new System.Drawing.Size(29, 22);
            this.audioDropDown.Text = "Audio";
            // 
            // allAudioMenuItem
            // 
            this.allAudioMenuItem.Image = global::MediaLibrary.Properties.Resources.audio_file_home;
            this.allAudioMenuItem.Name = "allAudioMenuItem";
            this.allAudioMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allAudioMenuItem.Tag = "type:audio";
            this.allAudioMenuItem.Text = "All Audio";
            this.allAudioMenuItem.Click += new System.EventHandler(this.SearchBookmark_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // audioFavoritesMenuItem
            // 
            this.audioFavoritesMenuItem.Image = global::MediaLibrary.Properties.Resources.audio_file_heart;
            this.audioFavoritesMenuItem.Name = "audioFavoritesMenuItem";
            this.audioFavoritesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.audioFavoritesMenuItem.Tag = "type:audio !favorite";
            this.audioFavoritesMenuItem.Text = "Favorite Audio";
            this.audioFavoritesMenuItem.Click += new System.EventHandler(this.SearchBookmark_Click);
            // 
            // audioStarsMenuItem
            // 
            this.audioStarsMenuItem.Image = global::MediaLibrary.Properties.Resources.audio_file_star;
            this.audioStarsMenuItem.Name = "audioStarsMenuItem";
            this.audioStarsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.audioStarsMenuItem.Tag = "type:audio stars:>=3";
            this.audioStarsMenuItem.Text = "Starred Audio";
            this.audioStarsMenuItem.Click += new System.EventHandler(this.SearchBookmark_Click);
            // 
            // imagesDropDown
            // 
            this.imagesDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imagesDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allImagesMenuItem,
            this.toolStripSeparator6,
            this.imageFavoritesMenuItem,
            this.imageStarsMenuItem});
            this.imagesDropDown.Image = global::MediaLibrary.Properties.Resources.picture_landscape;
            this.imagesDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imagesDropDown.Name = "imagesDropDown";
            this.imagesDropDown.Size = new System.Drawing.Size(29, 22);
            this.imagesDropDown.Text = "Images";
            // 
            // allImagesMenuItem
            // 
            this.allImagesMenuItem.Image = global::MediaLibrary.Properties.Resources.image_file_home;
            this.allImagesMenuItem.Name = "allImagesMenuItem";
            this.allImagesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allImagesMenuItem.Tag = "type:image";
            this.allImagesMenuItem.Text = "All Images";
            this.allImagesMenuItem.Click += new System.EventHandler(this.SearchBookmark_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // imageFavoritesMenuItem
            // 
            this.imageFavoritesMenuItem.Image = global::MediaLibrary.Properties.Resources.image_file_heart;
            this.imageFavoritesMenuItem.Name = "imageFavoritesMenuItem";
            this.imageFavoritesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imageFavoritesMenuItem.Tag = "type:image !favorite";
            this.imageFavoritesMenuItem.Text = "Favorite Images";
            this.imageFavoritesMenuItem.Click += new System.EventHandler(this.SearchBookmark_Click);
            // 
            // imageStarsMenuItem
            // 
            this.imageStarsMenuItem.Image = global::MediaLibrary.Properties.Resources.image_file_star;
            this.imageStarsMenuItem.Name = "imageStarsMenuItem";
            this.imageStarsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imageStarsMenuItem.Tag = "type:image stars:>=3";
            this.imageStarsMenuItem.Text = "Starred Images";
            this.imageStarsMenuItem.Click += new System.EventHandler(this.SearchBookmark_Click);
            // 
            // videoDropDown
            // 
            this.videoDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.videoDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allVideoMenuItem,
            this.toolStripSeparator7,
            this.videoFavoritesMenuItem,
            this.videoStarsMenuItem});
            this.videoDropDown.Image = global::MediaLibrary.Properties.Resources.video_player_movie;
            this.videoDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.videoDropDown.Name = "videoDropDown";
            this.videoDropDown.Size = new System.Drawing.Size(29, 22);
            this.videoDropDown.Text = "Videos";
            // 
            // allVideoMenuItem
            // 
            this.allVideoMenuItem.Image = global::MediaLibrary.Properties.Resources.video_file_home;
            this.allVideoMenuItem.Name = "allVideoMenuItem";
            this.allVideoMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allVideoMenuItem.Tag = "type:video";
            this.allVideoMenuItem.Text = "All Video";
            this.allVideoMenuItem.Click += new System.EventHandler(this.SearchBookmark_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(177, 6);
            // 
            // videoFavoritesMenuItem
            // 
            this.videoFavoritesMenuItem.Image = global::MediaLibrary.Properties.Resources.video_file_heart;
            this.videoFavoritesMenuItem.Name = "videoFavoritesMenuItem";
            this.videoFavoritesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.videoFavoritesMenuItem.Tag = "type:video !favorite";
            this.videoFavoritesMenuItem.Text = "Favorite Video";
            this.videoFavoritesMenuItem.Click += new System.EventHandler(this.SearchBookmark_Click);
            // 
            // videoStarsMenuItem
            // 
            this.videoStarsMenuItem.Image = global::MediaLibrary.Properties.Resources.video_file_star;
            this.videoStarsMenuItem.Name = "videoStarsMenuItem";
            this.videoStarsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.videoStarsMenuItem.Tag = "type:video stars:>=3";
            this.videoStarsMenuItem.Text = "Starred Video";
            this.videoStarsMenuItem.Click += new System.EventHandler(this.SearchBookmark_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(200, 25);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addIndexedFolderToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar mainProgressBar;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton playButton;
        private System.Windows.Forms.ToolStripButton playAllButton;
        private System.Windows.Forms.ToolStripButton shuffleAllButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton favoriteFilesDropDown;
        private System.Windows.Forms.ToolStripDropDownButton starredDropDown;
        private System.Windows.Forms.ToolStripMenuItem favoriteFilesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoriteAudioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoriteImagesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoriteVideoMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem starredFilesMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem starredAudioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem starredImagesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem starredVideoMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton audioDropDown;
        private System.Windows.Forms.ToolStripDropDownButton imagesDropDown;
        private System.Windows.Forms.ToolStripDropDownButton videoDropDown;
        private System.Windows.Forms.ToolStripMenuItem allAudioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem audioFavoritesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem audioStarsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allImagesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageFavoritesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageStarsMenuItem;
        private System.Windows.Forms.ToolStripButton homeButton;
        private System.Windows.Forms.ToolStripMenuItem allVideoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoFavoritesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoStarsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripTextBox searchBox;
    }
}
