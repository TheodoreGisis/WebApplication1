using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.Pages.Creator
{
    public class IndexModel : PageModel
    {
       
        public readonly MyDbContext _context;

        public IndexModel(MyDbContext context)
        {
            _context = context;
        }

        public List<WebApplication1.Models.Creator> creators;
        public void OnGet()
        {
            creators = _context.Creators.ToList(); 
        }

    }
}
