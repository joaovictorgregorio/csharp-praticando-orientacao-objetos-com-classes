using MedicalAppointmentScheduler;

Console.Clear();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("                     AGENDAMENTO MÉDICO");
Console.ResetColor();
Console.WriteLine();

var appointment = new Appointment("João Silva", "Dra. Renata", new DateOnly(2025, 5, 20));
appointment.DisplayResume();

Console.WriteLine();

appointment.Reschedule(new DateOnly(2026, 3, 19));
appointment.DisplayResume();