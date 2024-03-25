using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structural_design_patterns
{
    internal class SimpleText : IText
    {
        public string GetDescription()
        {
            return "Basic text(black text on white background)";
        }
    }
}
