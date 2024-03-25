using structural_design_patterns;

var text = Clerk.BoldWithColor("red");
var text2 = Clerk.BoldAndItalic();
var text3 = Clerk.BoldAndItalicAndUnderlineWithColor("blue");

Console.WriteLine(text.GetDescription());
Console.WriteLine(text2.GetDescription());
Console.WriteLine(text3.GetDescription());