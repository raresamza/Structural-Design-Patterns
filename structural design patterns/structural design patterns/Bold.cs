using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structural_design_patterns
{
    internal class Bold : BaseTextDecorator
    {
        public Bold(IText text) : base(text)
        {
        }

        public override string GetDescription()
        {
            return _text.GetDescription() + " + also bold";
        }
    }
}
