using RectangleAreaCalculator;

Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("                     CALCULANDO ÁREA DE RETÂNGULOS");
Console.ResetColor();
Console.WriteLine();

var rectangule = new Rectangle(5.0, 8.0);
Console.WriteLine("  Área do Retângulo: " + rectangule.CalculateArea());