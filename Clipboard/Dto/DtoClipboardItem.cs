using Clipboard.Enum;
using System.Net;
using System.Text.RegularExpressions;


namespace Clipboard.Dto
{
    public sealed record DtoClipboardItem
    {
        public ClipboardItemType Type { get; init; }

        public DateTime CreatedAt { get; init; }

        public string? Text { get; init; }

        public string? Html { get; init; }

        public IReadOnlyList<string> Files { get; init; } = [];

        public byte[]? ImageData { get; init; }

        public string TextToShow
        {
            get
            {
                switch (Type)
                {
                    case ClipboardItemType.Files:
                        return string.Join(
                            Environment.NewLine,
                            Files);

                    case ClipboardItemType.Html:
                        if (string.IsNullOrEmpty(Html))
                            return "Html";

                        string html = Html;

                        int start =
                            html.IndexOf("<!--StartFragment-->");

                        int end =
                            html.IndexOf("<!--EndFragment-->");

                        if (start >= 0 && end > start)
                        {
                            start += "<!--StartFragment-->".Length;

                            html =
                                html.Substring(
                                    start,
                                    end - start);
                        }

                        html = Regex.Replace(
                            html,
                            @"<[^>]*>",
                            "");

                        return WebUtility
                            .HtmlDecode(html)
                            .Trim();

                    case ClipboardItemType.Image:
                        return "Image Save as byte";

                    case ClipboardItemType.Text:
                        return string.IsNullOrEmpty(Text)
                            ? "Text"
                            : Text;

                    case ClipboardItemType.Unknown:
                        return "Unknown";

                    default:
                        return "";
                }
            }
        }
    }
}
