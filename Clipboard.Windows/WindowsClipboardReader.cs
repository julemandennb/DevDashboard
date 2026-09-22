using Clipboard.Dto;
using Clipboard.Enum;
using Clipboard.Interface;
using WinClipboard = System.Windows.Forms.Clipboard;
using System.Security.Cryptography;

namespace Clipboard.Windows
{
    public class WindowsClipboardReader : IClipboardReader
    {
        private string? _lastClipboardHash;

        public DtoClipboardItem? Read()
        {
            try
            {
                // Files
                if (WinClipboard.ContainsFileDropList())
                {
                    var files = WinClipboard.GetFileDropList();

                    var fileList = files.Cast<string>().ToArray();
                    var hash = ComputeHash(string.Join("\n", fileList));

                    if (_lastClipboardHash == hash)
                        return null;

                    _lastClipboardHash = hash;

                    return new DtoClipboardItem
                    {
                        Type = ClipboardItemType.Files,
                        CreatedAt = DateTime.Now,
                        Files = fileList
                    };
                }

                // Image
                if (WinClipboard.ContainsImage())
                {
                    using var image = WinClipboard.GetImage();

                    if (image is null)
                        return null;

                    using var stream = new MemoryStream();

                    image.Save(
                        stream,
                        System.Drawing.Imaging.ImageFormat.Png);

                    var imageData = stream.ToArray();
                    var hash = ComputeHash(imageData);

                    if (_lastClipboardHash == hash)
                        return null;

                    _lastClipboardHash = hash;

                    return new DtoClipboardItem
                    {
                        Type = ClipboardItemType.Image,
                        CreatedAt = DateTime.Now,
                        ImageData = imageData
                    };
                }

                // HTML
                if (WinClipboard.ContainsText(TextDataFormat.Html))
                {
                    var html = WinClipboard.GetText(TextDataFormat.Html);
                    var hash = ComputeHash(html);

                    if (_lastClipboardHash == hash)
                        return null;

                    _lastClipboardHash = hash;

                    return new DtoClipboardItem
                    {
                        Type = ClipboardItemType.Html,
                        CreatedAt = DateTime.Now,
                        Html = html
                    };
                }

                // Normal text
                if (WinClipboard.ContainsText())
                {
                    var text = WinClipboard.GetText();
                    var hash = ComputeHash(text);

                    if (_lastClipboardHash == hash)
                        return null;

                    _lastClipboardHash = hash;

                    return new DtoClipboardItem
                    {
                        Type = ClipboardItemType.Text,
                        CreatedAt = DateTime.Now,
                        Text = text
                    };
                }

                return null;
            }
            catch
            {
                // Clipboard can be temporarily unavailable.
                return null;
            }
        }

        private static string ComputeHash(string value)
        {
            return Convert.ToHexString(
                SHA256.HashData(
                    System.Text.Encoding.UTF8.GetBytes(value)));
        }

        private static string ComputeHash(byte[] value)
        {
            return Convert.ToHexString(
                SHA256.HashData(value));
        }
    }
}
