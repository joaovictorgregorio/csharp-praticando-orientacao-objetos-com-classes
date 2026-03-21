namespace InventoryManagementApp;

public class Product
{
    public Product(int inicialQuantity, string? name)
    {
        _stockQuantity = inicialQuantity;
        Name = name;
    }

    private int _stockQuantity { get; set; }
    public string? Name { get; set; }

    public void ToRemove(int quantity) 
    {
        if (_stockQuantity >= quantity)
        {
            _stockQuantity -= quantity;

            Console.WriteLine($"  Retirada de {quantity} unidades realizada com sucesso.");
        }
        else
        {
            Console.WriteLine($"  Erro: Estoque insuficiente para retirada de {quantity} unidades.");
        }
    }

    public string DisplayInventory() => $" \n  Produto: {Name} \n  Estoque:{_stockQuantity}";
}
