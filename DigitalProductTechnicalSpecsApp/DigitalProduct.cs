namespace DigitalProductTechnicalSpecsApp;

public class DigitalProduct
{
    public DigitalProduct(string? name, decimal price, TechnicalInformation? technicalInformation)
    {
        Name = name;
        Price = price;
        TechnicalInformation = technicalInformation;
    }

    public string? Name { get; set; }
    public decimal Price { get; set; }
    public TechnicalInformation? TechnicalInformation { get; set; }

    public void DisplayDetails() 
        => Console.WriteLine($" \n  Produto: {Name} \n  Preço: {Price:C} \n  Tamanho: {TechnicalInformation?.SizeMB}MB  \n  Compatível com: {TechnicalInformation?.OperatingSystem}");
}

