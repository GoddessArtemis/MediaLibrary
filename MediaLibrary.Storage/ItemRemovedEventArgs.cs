// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace MediaLibrary.Storage
{
    public class ItemRemovedEventArgs<T>
    {
        public ItemRemovedEventArgs(T item)
        {
            this.Item = item;
        }

        public T Item { get; }
    }
}
