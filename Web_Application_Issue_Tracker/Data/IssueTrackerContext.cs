using Microsoft.EntityFrameworkCore;
using Web_Application_Issue_Tracker.Models;
    

namespace Web_Application_Issue_Tracker.Data
{
    public class IssueTrackerContext : DbContext
    {
        public IssueTrackerContext (DbContextOptions<IssueTrackerContext> options)
            : base(options)
        {

        }

        public DbSet<Issue> Issue { get; set; }
    }
}
