using TitleGenerator;

Console.Clear();

Title title = new(["Hello", "World", "!"]);

title.Draw();

Console.WriteLine();

title.Text[0] = "Hellooo";
title.Text[1] = "Worlds";
title.Border = 2;

title.Draw();

Console.WriteLine();

title.PatternTop = '$';
title.PatternLeft = '@';
title.PatternRight = '#';
title.PatternBottom = '&';

title.DrawSlow();

Console.WriteLine();