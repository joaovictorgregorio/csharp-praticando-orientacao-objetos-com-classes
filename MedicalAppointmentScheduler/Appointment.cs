namespace MedicalAppointmentScheduler;

public class Appointment
{
    private bool ItWasRescheduled { get; set; }

    public Appointment(string? patientName, string? doctorName, DateOnly consultationDate)
    {
        PatientName = patientName;
        DoctorName = doctorName;
        ConsultationDate = consultationDate;
        ItWasRescheduled = false;
    }

    public string? PatientName { get; set; }
    public string? DoctorName { get; set; }
    public DateOnly ConsultationDate { get; set; }

    public void Reschedule(DateOnly newDate)
    {
        ConsultationDate = newDate;
        ItWasRescheduled = true;
    }

    public void DisplayResume()
    {
        if (ItWasRescheduled == false) 
            Console.WriteLine($" \n  Consulta marcada com {DoctorName} para o paciente {PatientName}. \n  Data: {ConsultationDate}");
        else 
            Console.WriteLine($" \n  Consulta marcada com {DoctorName} para o paciente {PatientName}. \n  Nova Data: {ConsultationDate}");
    }
}
