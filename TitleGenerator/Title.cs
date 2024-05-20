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

}