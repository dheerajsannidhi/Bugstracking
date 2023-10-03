using Bugstracking.Data;
using Bugstracking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bugstracking.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IssueDbContext _context;
        public IndexModel(IssueDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Issues = _context.Issues.Where(i => i.Completed == null)
            .OrderByDescending(i => i.Created).ToList();
        }

        public IEnumerable<Issue> Issues { get; set; } = Enumerable.Empty<Issue>();
    }
}