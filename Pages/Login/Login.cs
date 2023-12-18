
using System.ComponentModel.DataAnnotations;

namespace RazorPageExemplo.Pages.Login;

public class Login 
{      
    [Display(Name = "E-mail")]
    [EmailAddress]
    [Required(ErrorMessage = "O {0} é obrigatório")]
    public string Email { get; set; }

    [Display(Name = "Senha")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "A {0} é obrigatória")]
    public string Password { get; set; }
}