using GameStore.Dal;
using GameStore.Dal.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameStore.Pages.Home;

public class ProductDetails : PageModel
{
    public ProductDTO? Product { get; set; }
    private readonly AbstractStorage _storage;
    public ProductDetails(AbstractStorage storage)
    {
        _storage = storage;
    }
    public void OnGet(int? id)
    {
        if (id == null) RedirectToPage("/Home/Index");
        
        Product = _storage.Products.First(x=>x.Id == id);
        
        if (Product == null) RedirectToPage("/Home/Index");
    }
    

}


