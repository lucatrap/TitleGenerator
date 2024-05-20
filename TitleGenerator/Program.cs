using TitleGenerator;

Title title = new(["Hello", "World", "\t"], 100, '*', 1, 1);

Console.WriteLine(title.Text[0]);
Console.WriteLine(title.Pattern);