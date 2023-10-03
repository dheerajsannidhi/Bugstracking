using Bugstracking.Models;
using Microsoft.EntityFrameworkCore;

namespace Bugstracking.Data
{
    public class IssueDbContext: DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options) : base(options) { }

        public DbSet<Issue> Issues { get; set; }

    }
}
