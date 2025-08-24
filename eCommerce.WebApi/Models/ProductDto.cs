namespace eCommerce.WebApi.Models;

public class ProductDto
{
    public ProductDto(Guid id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }

    public void Update(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}