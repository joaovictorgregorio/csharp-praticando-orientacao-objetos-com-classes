using TravelTicketSystem;

Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("                     EMISSÃO DE PASSAGEM DE VIAGEM");
Console.ResetColor();
Console.WriteLine();

var ticket = new Ticket("João Victor", "Chile");
Console.WriteLine($"  Passageiro: {ticket.Passenger} \n  Destino: {ticket.Destination}");