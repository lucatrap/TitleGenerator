using TitleGenerator;

Console.Clear();

Title title = new(["Hello", "World", "!"]);

title.Draw();

Console.WriteLine();

title.Text[0] = "Hellooo";
title.Text[1] = "Worlds";
title.Text[2] = "!!!";
title.Border = 2;
title.PatternTop = '$';
title.PatternLeft = '@';
title.PatternRight = '#';
title.PatternBottom = '&';
title.PaddingTop = 2;
title.PaddingBottom = 0;

title.DrawSlow();

Console.WriteLine();
