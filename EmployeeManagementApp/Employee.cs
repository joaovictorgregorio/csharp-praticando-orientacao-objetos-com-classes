namespace EmployeeManagementApp
{
    public class Employee
    {
        public Employee(string? name, string? position)
        {
            Name = name;
            Position = position;
        }

        public string? Name { get; set; }
        public string? Position { get; set; }

        public void Promote(string newPosition)
        {
            if (Position == newPosition)
            {
                Thread.Sleep( 1000 );
                Console.WriteLine($"  Erro: O novo cargo deve ser diferente do cargo atual. \n  Cargo atual: {Position}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Thread.Sleep( 1000 );
                Console.WriteLine("\n  Promoção realizada com sucesso!  \n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep( 1000 );
                Console.WriteLine("  --- Após promoção ---  \n");
                Console.ResetColor();

                Console.WriteLine($"  Funcionário: {Name} \n  Cargo atual: {newPosition}");
            }
                
        }
    }
}
