using Clipboard.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clipboard.Interface
{
    public interface IClipboardHistory
    {

        void SetNewMax(int maxItems);

        void Add(DtoClipboardItem item);

        void Clear();

        List<DtoClipboardItem> GetList();

        DtoClipboardItem? Get(int index);
    }
}
