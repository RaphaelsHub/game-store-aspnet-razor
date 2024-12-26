using GameStore.Dal;
using GameStore.Dal.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameStore.Pages.Home;

public class Contact : PageModel
{
    [BindProperty] public ContactDataDTO ContactData { get; set; } = null!;
    private AbstractStorage _abstractStorage;
    public Contact(AbstractStorage abstractStorage)
    {
        _abstractStorage = abstractStorage;
    }
    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        _abstractStorage.ContactData.Add(ContactData);

        return RedirectToPage("/Home/Index");
    }

    public void OnGet()
    {
        
    }
}