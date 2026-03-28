namespace DigitalProductTechnicalSpecsApp;

public class TechnicalInformation
{
    public TechnicalInformation(string? operatingSystem, int sizeMB)
    {
        OperatingSystem = operatingSystem;
        SizeMB = sizeMB;
    }

    public string? OperatingSystem { get; set; }
    public int SizeMB { get; set; }
}
