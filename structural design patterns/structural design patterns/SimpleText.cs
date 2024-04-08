namespace structural_design_patterns;

internal class SimpleText : IText
{
    public string GetDescription()
    {
        return "Basic text(black text on white background)";
    }
}
