using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class ListModel : PageModel
    {
        public List<string> Items {get; set;} = new();

        public void onGet(){
            Items = new List<string> { "Item 1", "Item 2"};
        }
    }
}
