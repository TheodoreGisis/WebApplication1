using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Database;

namespace WebApplication1.Pages.Backer
{
    public class CatygoriesModel : PageModel
    {

        private MyDbContext _context;

        public List<WebApplication1.Models.Project>? ProjectByCatygory { get; set; } =new List< WebApplication1.Models.Project >();
        [BindProperty] public WebApplication1.Models.Category  Category_name { get; set; }
        


        public CatygoriesModel(MyDbContext context)
        {
            _context = context;
        }


        public void OnGet() { }
        public void OnPost()
        {
            ProjectByCatygory = (from n in _context.Category
                                 join p in _context.Projects on n.Id equals p.CategoryId
                                 where n.CategoryName == Category_name.CategoryName
                                 select new WebApplication1.Models.Project(p.title, p.description, p.moneyCollected, p.price)).ToList();
        }

 

    }
}
