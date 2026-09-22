using Clipboard.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clipboard.Interface
{
    public interface IClipboardReader
    {
        DtoClipboardItem? Read();
    }
}
