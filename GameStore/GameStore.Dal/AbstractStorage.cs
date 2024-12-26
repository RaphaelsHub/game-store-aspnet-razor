using GameStore.Dal.DTOs;

namespace GameStore.Dal;

public class AbstractStorage 
{
    public List<int> Subscriptions { get; set; } = new();
    public List<ProductDTO> Products { get;} = new();
    public List<ContactDataDTO> ContactData { get; set; } = new();

    
    public AbstractStorage()
    {
        InitProducts();
    }
    
    private void InitProducts()
    {
        string[] files = Directory.GetFiles($"{Directory.GetCurrentDirectory()}/wwwroot/PhotoProducts");
        for (int i = 0; i < Math.Min(files.Length, 10); i++)
        {
            if (File.Exists(files[i]))
            {
                Products.Add(new ProductDTO
                {
                    Id = i,
                    Name = $"Product {i}",
                    Description = $"Description {i}",
                    OriginalPrice = i * 10,
                    DiscountedPrice = i * 5,
                    Category = $"Category {i}",
                    TemplateInfo = $"TemplateInfo {i}",
                    IsAvailable = i % 2 == 0,
                    Genre = $"Genre {i}",
                    MultiTags = $"MultiTags {i}",
                    Image = File.ReadAllBytes(files[i])
                });
            }
        }
    }
}