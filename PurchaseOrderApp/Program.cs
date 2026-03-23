using PurchaseOrderApp;

Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("                     PEDIDO DE COMPRA");
Console.ResetColor();
Console.WriteLine();


var order = new Order("001", "Ana Silva", "Pendente");
order.DisplayOrder();

Console.WriteLine();

order.UpdateStatus("Enviado");
order.DisplayOrder();