using GameStore.Dal;
using GameStore.Dal.DTOs;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameStore.Pages.Home;

public class IndexModel : PageModel
{
    private readonly AbstractStorage _abstractStorage;
    private readonly ILogger<IndexModel> _logger;

    public List<ProductDTO> Products { get; set; } = new();

    public IndexModel(AbstractStorage abstractStorage, ILogger<IndexModel> logger)
    {
        _abstractStorage = abstractStorage;
        _logger = logger;
    }

    public void OnGet()
    {
        Products = _abstractStorage.Products;
    }

    public void OnGetSignIn()
    {
        ViewData["IsAuthorized"] = true;
        OnGet();
    }
    
    public void OnGetSignUp()
    {
        ViewData["IsAuthorized"] = true;
        OnGet();
    }
    
    public void OnGetSignOut()
    {
        ViewData["IsAuthorized"] = false;
        OnGet();
    }
}