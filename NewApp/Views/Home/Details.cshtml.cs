using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NewApp.Views.Home
{
    public class Details : PageModel
    {
        public void OnGet()
        {
            
        }

        public object Id { get; set; }
        public object Name { get; set; }
        public object Email { get; set; }
        public object Salary { get; set; }
    }
}