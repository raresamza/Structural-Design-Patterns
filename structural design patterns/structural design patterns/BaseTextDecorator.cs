using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structural_design_patterns
{
    internal abstract class BaseTextDecorator : IText
    {
        protected IText _text;

        public BaseTextDecorator(IText text)
        {
            _text = text;
        }

        public abstract string GetDescription();
    }

}
