using TitleGenerator;

Console.Clear();

Title title = new(["Hello", "World", "!"]);

title.Draw();

Console.WriteLine();

title.Text[0] = "Hellooo";
title.Text[1] = "Worlds";
title.Text[2] = "!!!";
title.BorderTop = 2;
title.BorderLeft = 7;
title.BorderRight = 4;
title.BorderBottom = 1;
title.PatternTop = '$';
title.PatternLeft = '@';
title.PatternRight = '#';
title.PatternBottom = '&';
title.PaddingTop = 0;
title.PaddingBottom = 2;

title.DrawSlow();

Console.WriteLine();
