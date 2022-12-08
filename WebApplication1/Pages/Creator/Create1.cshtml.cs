using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Database;

namespace WebApplication1.Pages.Creator
{
    public class Create1Model : PageModel
    {
        private MyDbContext _context;

        [BindProperty] public WebApplication1.Models.Creator creator { get; set; }
        public WebApplication1.Models.Creator creator1 { get; set; }
        public List<WebApplication1.Models.Project> creators { get; set; }
        public Create1Model(MyDbContext context)
        {
            _context = context;

        }
        public async Task<ActionResult> OnGet(string name)
        {
            creator = await _context.Creators.SingleOrDefaultAsync(a => a.firstName == name);
            if (creator is null) return BadRequest();
            creators = await _context.Projects.Where(m => m.CreatorId == creator.Id).ToListAsync();
            return Page();

        }
    }
}
