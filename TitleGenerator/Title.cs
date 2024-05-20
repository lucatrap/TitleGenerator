namespace TitleGenerator;

public class Title
{
    // Properties
    public string[] Text { get; set; }
    public int Width { get; set; }
    public char PatternTop { get; set; }
    public char PatternLeft { get; set; }
    public char PatternRight { get; set; }
    public char PatternBottom { get; set; }
    public int Padding { get; set; }
    public int Border { get; set; }

    // Constructor
    public Title(string[] text, int width = 100, char patternTop = '*', char patternLeft = '*', char patternRight = '*', char patternBottom = '*', int padding = 1, int border = 1)
    {
        Text = text;
        Width = Math.Min(Console.WindowWidth, width) / 2 * 2; // Avoids line overflow + keeps width even for simplicity

        PatternTop = patternTop;
        PatternLeft = patternLeft;
        PatternRight = patternRight;
        PatternBottom = patternBottom;
        
        Padding = padding;
        Border = border;
    }

    // Methods
    public void Draw()
    {
        for (int i = 0; i < Border; i++)
        {
            Console.WriteLine(new string(PatternTop, Width));
        }

        for (int i = 0; i < Padding; i++)
        {
            Console.WriteLine(new string(PatternLeft, Border) + new string(' ', Width - Border - Border) + new string(PatternRight, Border));
        }

        foreach (string line in Text)
        {
            // Adjust right padding if line length is odd to avoid asymmetrical border
            Console.WriteLine(new string(PatternLeft, Border) + new string(' ', (Width - Border - Border - line.Length) / 2) + line + (line.Length % 2 == 1 ? " " : "") + new string(' ', (Width - Border - Border - line.Length) / 2) + new string(PatternRight, Border));
        }

        for (int i = 0; i < Padding; i++)
        {
            Console.WriteLine(new string(PatternLeft, Border) + new string(' ', Width - Border - Border) + new string(PatternRight, Border));
        }

        for (int i = 0; i < Border; i++)
        {
            Console.WriteLine(new string(PatternBottom, Width));
        }     
    }

    public void DrawSlow()
    {
        int smallDelay = 200;
        int mediumDelay = 400;
        int longDelay = 800;

        Thread.Sleep(mediumDelay);

        for (int i = 0; i < Border; i++)
        {
            Console.WriteLine(new string(PatternTop, Width));
            Thread.Sleep(smallDelay);
        }

        for (int i = 0; i < Padding; i++)
        {
            Console.WriteLine(new string(PatternLeft, Border) + new string(' ', Width - Border - Border) + new string(PatternRight, Border));
            Thread.Sleep(smallDelay);
        }

        foreach (string line in Text)
        {
            // Adjust right padding if line length is odd to avoid asymmetrical border
            Console.WriteLine(new string(PatternLeft, Border) + new string(' ', (Width - Border - Border - line.Length) / 2) + line + (line.Length % 2 == 1 ? " " : "") + new string(' ', (Width - Border - Border - line.Length) / 2) + new string(PatternRight, Border));
            Thread.Sleep(smallDelay);
        }

        for (int i = 0; i < Padding; i++)
        {
            Console.WriteLine(new string(PatternLeft, Border) + new string(' ', Width - Border - Border) + new string(PatternRight, Border));
            Thread.Sleep(smallDelay);
        }

        for (int i = 0; i < Border; i++)
        {
            Console.WriteLine(new string(PatternBottom, Width));
            Thread.Sleep(smallDelay);
        }

        Thread.Sleep(longDelay);
    }
}