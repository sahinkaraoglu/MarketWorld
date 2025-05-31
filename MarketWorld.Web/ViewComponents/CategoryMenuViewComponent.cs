using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Infrastructure.Context;

namespace MarketWorld.Web.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        private readonly MarketWorldDbContext _context;

        public CategoryMenuViewComponent(MarketWorldDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _context.Categories
                .Include(c => c.SubCategories)
                .Where(c => !c.IsDeleted)
                .OrderBy(c => c.Name)
                .ToListAsync();

            return View(categories);
        }
    }
} 