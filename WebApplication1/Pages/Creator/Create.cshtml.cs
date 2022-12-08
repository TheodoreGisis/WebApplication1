using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Database;
using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Pages.Creator
{
    public class CreateModel : PageModel
    {
        private MyDbContext _context { get; set; }
        [BindProperty] public WebApplication1.Models.Creator creator { get; set; }
        [BindProperty] public WebApplication1.Models.Project project { get; set; }
        [BindProperty] public WebApplication1.Models.Category category { get; set; }

        public int CreatorCount { get; set; }

        public CreateModel(MyDbContext context)
        {
            _context = context;

        }   
        public void OnGet()
        {
            CreatorCount = _context.Creators.Count();
        }
        public async Task<ActionResult> OnPost()
        {
            _context.Creators.Add(creator);
            _context.Category.Add(category);
            await _context.SaveChangesAsync();
            var category1 =  await _context.Category.FirstAsync(c => c.CategoryName == category.CategoryName);
            var creator1 = await _context.Creators.FirstAsync(c => c.firstName == creator.firstName &&c.lastName == creator.lastName );
            project.category = category1;
            project.CreatorId = creator1.Id;
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();
            

            return RedirectToPage("/Index");

        }
    }
}
