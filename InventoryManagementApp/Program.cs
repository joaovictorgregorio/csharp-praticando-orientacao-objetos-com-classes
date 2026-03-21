using InventoryManagementApp;

Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("                     CONTROLE DE ESTOQUE");
Console.ResetColor();
Console.WriteLine();

var product = new Product(20, "Caneta Azul");
product.ToRemove(5);
product.DisplayInventory();
product.ToRemove(30);
