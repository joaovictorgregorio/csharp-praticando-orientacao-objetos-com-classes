using EmployeeManagementApp;

Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("                     GERENCIAMENTO DE FUNCIONÁRIOS");
Console.ResetColor();
Console.WriteLine();


var employee = new Employee("João Silva", "Estagiário");
employee.Promote("Estagiário");
employee.Promote("Analista");