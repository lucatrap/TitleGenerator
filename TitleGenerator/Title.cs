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
    public Title(string[] text, int width = 100, char pattern = '*', int padding = 1, int border = 1)
    {
        Text = text;
        Width = Math.Min(Console.WindowWidth, width) / 2 * 2; // Avoids line overflow + keeps width even for simplicity
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
            // Adjust right padding if line length is odd to avoid asymmetrical border
            if (line.Length % 2 == 1)
            {
                Console.WriteLine(new string(Pattern, Border) + new string(' ', (Width - Border - Border - line.Length) / 2) + line + " " + new string(' ', (Width - Border - Border - line.Length) / 2) + new string(Pattern, Border));
            }
            else
            {
                Console.WriteLine(new string(Pattern, Border) + new string(' ', (Width - Border - Border - line.Length) / 2) + line + new string(' ', (Width - Border - Border - line.Length) / 2) + new string(Pattern, Border));
            }
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