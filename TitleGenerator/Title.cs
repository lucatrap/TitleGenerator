namespace TitleGenerator;

public class Title
{
    // Properties
    public string[] Text { get; set; }
    public int Width { get; set; }
    public char Pattern { get; set; }
    public int Padding { get; set; }
    public int Border { get; set; }

    // Constructor
    public Title(string[] text, int width, char pattern, int padding, int border)
    {
        Text = text;
        Width = width;
        Pattern = pattern;
        Padding = padding;
        Border = border;
    }

    // Methods
    public void Draw()
    {
        for (int i = 0; i < Border; i++)
        {
            Console.WriteLine(new string(Pattern, Width));
        }

        for (int i = 0; i < Padding; i++)
        {
            Console.WriteLine(new string(Pattern, Border) + new string(' ', Width - Border - Border) + new string(Pattern, Border));
        }

        foreach (string line in Text)
        {
            Console.WriteLine(new string(Pattern, Border) + new string(' ', (Width - Border - Border - line.Length) / 2) + line + new string(' ', (Width - Border - Border - line.Length) / 2) + new string(Pattern, Border));
        }

        for (int i = 0; i < Padding; i++)
        {
            Console.WriteLine(new string(Pattern, Border) + new string(' ', Width - Border - Border) + new string(Pattern, Border));
        }

        for (int i = 0; i < Border; i++)
        {
            Console.WriteLine(new string(Pattern, Width));
        }     
    }
}