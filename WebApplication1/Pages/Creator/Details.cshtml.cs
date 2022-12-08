using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.Pages.Creator
{
    public class DetailsModel : PageModel
    {
        private MyDbContext _context { get; set; }

        public WebApplication1.Models.Creator creator { get; set; }
        public List<WebApplication1.Models.Project> creators { get; set; }

        public double percent { get; set; }
        public  DetailsModel(MyDbContext context)   
        {
            _context = context;
        }

        public async Task<ActionResult> OnGet(int id)
        {
            creator = await _context.Creators.SingleOrDefaultAsync(a => a.Id == id);
            if (creator is null) return BadRequest();
            creators = await _context.Projects.Where(m => m.CreatorId==creator.Id).ToListAsync();
           
            return Page();

        }
    }
}
