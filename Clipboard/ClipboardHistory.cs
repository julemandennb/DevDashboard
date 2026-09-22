using Clipboard.Dto;
using Clipboard.Interface;

namespace Clipboard
{
    public class ClipboardHistory: IClipboardHistory
    {
        private int _maxItems;

        private readonly List<DtoClipboardItem> _items = [];

        public int MaxItems => _maxItems;

        public ClipboardHistory(int maxItems = 15)
        {
            SetNewMax(maxItems);
        }

        public void SetNewMax(int maxItems)
        {
            if (maxItems < 1)
                throw new ArgumentOutOfRangeException(nameof(maxItems));

            _maxItems = maxItems;

            Trim();
        }

        public void Add(DtoClipboardItem item)
        {
            ArgumentNullException.ThrowIfNull(item);

            _items.Insert(0, item);

            Trim();
        }

        public void Clear()
        {
            _items.Clear();
        }

        public List<DtoClipboardItem> GetList()
        {
            return _items;
        }

        public DtoClipboardItem? Get(int index)
        {
            if (index < 0 || index >= _items.Count)
                return null;

            return _items[index];
        }

        private void Trim()
        {
            if (_items.Count <= _maxItems)
                return;

            _items.RemoveRange(
                _maxItems,
                _items.Count - _maxItems);
        }
    }
}
