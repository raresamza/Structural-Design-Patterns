using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structural_design_patterns
{
    internal class Color : BaseTextDecorator
    {

        string color;
        public Color(IText text, string color) : base(text)
        {
            this.color = color;
        }

        public override string GetDescription()
        {
            return _text.GetDescription() + $" + the text is colored: {color}";
        }
    }
}
