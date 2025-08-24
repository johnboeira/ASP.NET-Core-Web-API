using eCommerce.WebApi.Models;

namespace eCommerce.WebApi.Infra;

public class ProductRepository
{
    private static List<ProductDto> _products = new List<ProductDto>()
    {
        new ProductDto(new Guid("11111111-2222-3333-4444-555555555555"), "Notebook Gamer", 8500.00m),
        new ProductDto(Guid.NewGuid(), "Notebook Ultrafino", 6200.00m),
        new ProductDto(Guid.NewGuid(), "Notebook 2 em 1", 5500.00m),
        new ProductDto(Guid.NewGuid(), "Smartphone Android", 2800.00m),
        new ProductDto(Guid.NewGuid(), "iPhone 15", 7200.00m),
        new ProductDto(Guid.NewGuid(), "Tablet Android", 1800.00m),
        new ProductDto(Guid.NewGuid(), "iPad Air", 4500.00m),
        new ProductDto(Guid.NewGuid(), "Kindle Paperwhite", 650.00m),
        new ProductDto(Guid.NewGuid(), "Monitor 24'' Full HD", 800.00m),
        new ProductDto(Guid.NewGuid(), "Monitor 32'' 4K", 2200.00m),

        new ProductDto(Guid.NewGuid(), "Teclado Mecânico RGB", 480.00m),
        new ProductDto(Guid.NewGuid(), "Teclado sem fio", 220.00m),
        new ProductDto(Guid.NewGuid(), "Mouse Gamer RGB", 320.00m),
        new ProductDto(Guid.NewGuid(), "Mouse sem fio", 180.00m),
        new ProductDto(Guid.NewGuid(), "Headset Gamer", 600.00m),
        new ProductDto(Guid.NewGuid(), "Fone Bluetooth", 300.00m),
        new ProductDto(Guid.NewGuid(), "Caixa de Som Inteligente", 550.00m),
        new ProductDto(Guid.NewGuid(), "Soundbar", 1200.00m),
        new ProductDto(Guid.NewGuid(), "Microfone USB", 350.00m),
        new ProductDto(Guid.NewGuid(), "Webcam Full HD", 280.00m),

        new ProductDto(Guid.NewGuid(), "SSD NVMe 1TB", 750.00m),
        new ProductDto(Guid.NewGuid(), "SSD SATA 512GB", 350.00m),
        new ProductDto(Guid.NewGuid(), "HD Externo 2TB", 500.00m),
        new ProductDto(Guid.NewGuid(), "Placa de Vídeo RTX 4070", 4200.00m),
        new ProductDto(Guid.NewGuid(), "Placa de Vídeo RTX 4090", 12000.00m),
        new ProductDto(Guid.NewGuid(), "Placa-Mãe ATX", 900.00m),
        new ProductDto(Guid.NewGuid(), "Processador Intel i9", 3500.00m),
        new ProductDto(Guid.NewGuid(), "Processador Ryzen 9", 3200.00m),
        new ProductDto(Guid.NewGuid(), "Memória RAM 16GB", 400.00m),
        new ProductDto(Guid.NewGuid(), "Memória RAM 32GB", 780.00m),

        new ProductDto(Guid.NewGuid(), "Fonte 750W Modular", 600.00m),
        new ProductDto(Guid.NewGuid(), "Gabinete Gamer RGB", 750.00m),
        new ProductDto(Guid.NewGuid(), "Water Cooler 240mm", 850.00m),
        new ProductDto(Guid.NewGuid(), "Cooler de CPU", 250.00m),
        new ProductDto(Guid.NewGuid(), "Roteador Wi-Fi 6", 700.00m),
        new ProductDto(Guid.NewGuid(), "Switch Gigabit 8 Portas", 320.00m),
        new ProductDto(Guid.NewGuid(), "HDMI Cable 2m", 60.00m),
        new ProductDto(Guid.NewGuid(), "Carregador Portátil 20.000mAh", 220.00m),
        new ProductDto(Guid.NewGuid(), "Estabilizador 1000VA", 480.00m),
        new ProductDto(Guid.NewGuid(), "Nobreak 1500VA", 950.00m),

        new ProductDto(Guid.NewGuid(), "Drone 4K", 5800.00m),
        new ProductDto(Guid.NewGuid(), "Drone Profissional", 12500.00m),
        new ProductDto(Guid.NewGuid(), "Câmera DSLR", 5200.00m),
        new ProductDto(Guid.NewGuid(), "Câmera Mirrorless", 6800.00m),
        new ProductDto(Guid.NewGuid(), "GoPro Hero", 2500.00m),
        new ProductDto(Guid.NewGuid(), "Smartwatch", 1200.00m),
        new ProductDto(Guid.NewGuid(), "Óculos de Realidade Virtual", 3500.00m),
        new ProductDto(Guid.NewGuid(), "Console PlayStation 5", 4200.00m),
        new ProductDto(Guid.NewGuid(), "Console Xbox Series X", 3900.00m),
        new ProductDto(Guid.NewGuid(), "Nintendo Switch OLED", 2800.00m),
    };

    public async Task<ProductDto> GetByIdAsync(Guid id)
    {
        await Task.Delay(600); // simulando I/O (Banco)
        return _products.SingleOrDefault(p => p.Id == id)!;
    }

    public async Task<IEnumerable<ProductDto>> GetAllAsync()
    {
        await Task.Delay(700); // simulando I/O (Banco)
        return _products;
    }

    public async Task<ProductDto> CreateAsync(ProductCreateDto product)
    {
        await Task.Delay(700); // simulando I/O (Banco)
        var newProduct = new ProductDto(Guid.NewGuid(), product.Name, product.Price);

        _products.Add(newProduct);

        return newProduct;
    }

    internal async Task<bool> DeleteAsync(ProductDto productToDelete)
    {
        await Task.Delay(700); // simulando I/O (Banco)
        return _products.Remove(productToDelete);
    }
}