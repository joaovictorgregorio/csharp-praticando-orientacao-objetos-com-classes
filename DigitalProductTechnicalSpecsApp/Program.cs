using DigitalProductTechnicalSpecsApp;

Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("                     INFORMAÇÕES TÉCNICAS PRODUTO DIGITAL");
Console.ResetColor();
Console.WriteLine();


var info = new TechnicalInformation("Windows/Mac/Linux", 3200);
var product = new DigitalProduct("Microsoft Office", 93.95m, info);

product.DisplayDetails();