
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageExemplo.Pages.Home;

public class IndexModel : PageModel
{

    public string Message { get; private set; } = "Hello World";
    public void OnGet()
    {
      Message = "Jose";
    }

    public void OnPost(int id)
    {
        Console.WriteLine(id);
    }
}