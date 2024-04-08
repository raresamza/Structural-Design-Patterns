namespace structural_design_patterns;

internal class Italic : BaseTextDecorator
{
    public Italic(IText text) : base(text)
    {
    }

    public override string GetDescription()
    {
        return _text.GetDescription() + " + also italic";
    }
}
