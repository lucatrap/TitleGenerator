using TitleGenerator;

Title title = new(["Hello", "World", "!"]);

title.Draw();

Console.WriteLine();

title.Text[0] = "Hellooo";
title.Text[1] = "Worlds";
title.Pattern = '\\';
title.Border = 2;

title.DrawSlow();

Console.WriteLine();