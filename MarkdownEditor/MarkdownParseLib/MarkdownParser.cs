using System;
using Markdig;

namespace MarkdownParseLib
{
    public class MarkdownParser
    {
        public static string ParseHtml(string markdown)
        {
            return Markdown.ToHtml(markdown);
        }
    }
}
