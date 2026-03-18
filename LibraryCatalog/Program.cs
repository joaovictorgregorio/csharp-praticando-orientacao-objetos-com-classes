using LibraryCatalog;

Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("                     CADASTRO DE LIVROS NA BIBLIOTECA");
Console.ResetColor();
Console.WriteLine();

var myBook = new Book();
myBook.Title = "Essencialismo";
myBook.Author = "Greg Mckeown";

Console.WriteLine($"  Livro: {myBook.Title} \n  Autor: {myBook.Author}");
