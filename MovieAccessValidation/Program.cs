using MovieAccessValidation;

Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("                     ACESSO A FILMES");
Console.ResetColor();
Console.WriteLine();

var movie = new Movie("Matrix", 16);
movie.DisplayResult(14);
movie.DisplayResult(18);