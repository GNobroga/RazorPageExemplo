
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageExemplo.Pages.Login;

public class LoginModel : PageModel
{   
    [BindProperty]
    public Login Login { get; set; }

    public void OnGet()
    {
 
    }

    public void OnGetSayHello()
    {
        Console.WriteLine("Oi Gabigol");
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid) 
        {   
            return Page();
        }

        return RedirectToPage("/Home/Index");
    }

}