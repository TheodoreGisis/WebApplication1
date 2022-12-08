using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Database;

namespace WebApplication1.Pages.Tradings
{
    public class IndexModel : PageModel
    {

        private MyDbContext _context;

        public List<WebApplication1.Models.Project> TradingProject { get; set; }
        public IndexModel(MyDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            TradingProject  = (from n in _context.Projects
                              orderby n.moneyCollected descending
                               select n).ToList();


        }
    }
}
