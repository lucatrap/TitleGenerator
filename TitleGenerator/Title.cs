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
    public int PaddingTop { get; set; }
    public int PaddingBottom { get; set; }
    public int BorderTop { get; set; }
    public int BorderLeft { get; set; }
    public int BorderRight { get; set; }
    public int BorderBottom { get; set; }

    // Constructor
    public Title(string[] text, int width = 100, char patternTop = '*', char patternLeft = '*', char patternRight = '*', char patternBottom = '*', int paddingTop = 1, int paddingBottom = 1, int borderTop = 1, int borderLeft = 1, int borderRight = 1, int borderBottom = 1)
    {
        Text = text;
        Width = Math.Min(Console.WindowWidth, width) / 2 * 2; // Avoids line overflow + keeps width even for simplicity

        PatternTop = patternTop;
        PatternLeft = patternLeft;
        PatternRight = patternRight;
        PatternBottom = patternBottom;

        PaddingTop = paddingTop;
        PaddingBottom = paddingBottom;

        BorderTop = borderTop;
        BorderLeft = borderLeft;
        BorderRight = borderRight;
        BorderBottom = borderBottom;
    }

    // Methods
    public void Draw()
    {
        for (int i = 0; i < BorderTop; i++)
        {
            Console.WriteLine(new string(PatternTop, Width));
        }

        for (int i = 0; i < PaddingTop; i++)
        {
            Console.WriteLine(new string(PatternLeft, BorderLeft) + new string(' ', Width - BorderLeft - BorderRight) + new string(PatternRight, BorderRight));
        }

        foreach (string line in Text)
        {
            // Adjust right padding if line length is odd to avoid asymmetrical border
            string adjustedLine = line.Length % 2 == 1 ? line + " " : line;
            bool oddBorderWidth = (BorderLeft + BorderRight) % 2 == 1;
            
            Console.WriteLine(new string(PatternLeft, BorderLeft) + new string(' ', (Width - BorderLeft - BorderRight - adjustedLine.Length) / 2) + adjustedLine + new string(' ', (Width - BorderLeft - BorderRight - adjustedLine.Length) / 2 + (oddBorderWidth ? 1 : 0)) + new string(PatternRight, BorderRight));
        }

        for (int i = 0; i < PaddingBottom; i++)
        {
            Console.WriteLine(new string(PatternLeft, BorderLeft) + new string(' ', Width - BorderLeft - BorderRight) + new string(PatternRight, BorderRight));
        }

        for (int i = 0; i < BorderBottom; i++)
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

        for (int i = 0; i < BorderTop; i++)
        {
            Console.WriteLine(new string(PatternTop, Width));
            Thread.Sleep(smallDelay);
        }

        for (int i = 0; i < PaddingTop; i++)
        {
            Console.WriteLine(new string(PatternLeft, BorderLeft) + new string(' ', Width - BorderLeft - BorderRight) + new string(PatternRight, BorderRight));
            Thread.Sleep(smallDelay);
        }

        foreach (string line in Text)
        {
            // Adjust right padding if line length is odd to avoid asymmetrical border
            string adjustedLine = line.Length % 2 == 1 ? line + " " : line;
            bool oddBorderWidth = (BorderLeft + BorderRight) % 2 == 1;

            Console.WriteLine(new string(PatternLeft, BorderLeft) + new string(' ', (Width - BorderLeft - BorderRight - adjustedLine.Length) / 2) + adjustedLine + new string(' ', (Width - BorderLeft - BorderRight - adjustedLine.Length) / 2 + (oddBorderWidth ? 1 : 0)) + new string(PatternRight, BorderRight));
            Thread.Sleep(smallDelay);
        }

        for (int i = 0; i < PaddingBottom; i++)
        {
            Console.WriteLine(new string(PatternLeft, BorderLeft) + new string(' ', Width - BorderLeft - BorderRight) + new string(PatternRight, BorderRight));
            Thread.Sleep(smallDelay);
        }

        for (int i = 0; i < BorderBottom; i++)
        {
            Console.WriteLine(new string(PatternBottom, Width));
            Thread.Sleep(smallDelay);
        }

        Thread.Sleep(longDelay);
    }
}