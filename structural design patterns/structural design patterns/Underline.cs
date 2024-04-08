namespace structural_design_patterns;

internal class Underline : BaseTextDecorator
{
    public Underline(IText text) : base(text)
    {
    }

    public override string GetDescription()
    {
        return _text.GetDescription() + " + also underline";
    }
}
