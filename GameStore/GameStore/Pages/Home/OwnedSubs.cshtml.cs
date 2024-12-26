using GameStore.Dal;
using GameStore.Dal.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameStore.Pages.Home;

public class OwnedSubs : PageModel
{
    public List<ProductDTO> Products { get; set; } = new();
    
    private AbstractStorage _storage;
    
    public OwnedSubs(AbstractStorage storage)
    {
        _storage = storage;
        foreach (var a in _storage.Subscriptions)
        {
            var product =_storage.Products.Find(x=>x.Id == a);
            if (product != null)
                Products.Add(product); 
        }
    }
    
    public void OnGet()
    {
        
    }
    
    public IActionResult OnPostSubscribe(int? id)
    {
        if (id == null) RedirectToPage("/Home/Index");
        
        var isSubscribed = _storage.Subscriptions.Contains((int)id!);
        
        if (!isSubscribed) _storage.Subscriptions.Add((int)id!);
        
        return RedirectToPage("/Home/ProductDetails", new {id});
    }
    
    public IActionResult OnPostUnSubscribe(int? id)
    {
        if (id == null) RedirectToPage("/Home/Index");
        
        var isSubscribed = _storage.Subscriptions.Contains((int)id!);
        
        if (isSubscribed) _storage.Subscriptions.Remove((int)id!);
        
        return RedirectToPage("/Home/Index");
    }
}