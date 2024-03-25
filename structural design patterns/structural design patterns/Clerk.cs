using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structural_design_patterns
{
    internal static class Clerk
    {
        public static IText BoldWithColor(string color)
        {
            IText text = new SimpleText();
            text = new Bold(text);
            text = new Color(text, color);
            return text;
        }
        public static IText BoldAndItalic()
        {
            IText text = new SimpleText();
            text = new Bold(text);
            text = new Italic(text);
            return text;
        }
        public static IText BoldAndItalicAndUnderlineWithColor(string color)
        {
            IText text = new SimpleText();
            text = new Bold(text);
            text = new Italic(text);
            text = new Underline(text);
            text = new Color(text, color);
            return text;
        }
    }
}
