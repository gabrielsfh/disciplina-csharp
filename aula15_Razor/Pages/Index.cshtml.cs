using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aula15_Razor.Pages;

public class IndexModel : PageModel
{   
    [BindProperty]
    public string? Name{get; set;}
    public string? Message {get; set;}

    public void onPost(){
        if(!string.IsNullOrEmpty(Name)){
            Message = $"Olá, {Name}! Bem vindo ao Razor Pages.";
        }
    }

}
