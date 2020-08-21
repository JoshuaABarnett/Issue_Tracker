using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Web_Application_Issue_Tracker.Data;
using System;
using System.Linq;

namespace Web_Application_Issue_Tracker.Models
{
    public class SeedData
    {    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new IssueTrackerContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<IssueTrackerContext>>()))
        {
            // Look for any issues.
            if (context.Issue.Any())
            {
                return;   // DB has been seeded
            }

            context.Issue.AddRange(
                new Issue
                {
                    Title = "Program crashes",
                    Description = "After login, users on Safari browsers experience crashes every Thursday at 2pm.",
                    Priority = "1",
                    Author = "Albert Einstein",
                    Project = "Public Transportation App",
                    CreationDate = DateTime.Parse("2020-3-20"),
                    Developer = "Alan Turing",
                    Status = "Pending"
                },

                new Issue
                {
                    Title = "Unexpected exits",
                    Description = "After login, mac users experience program windows closing every Thursday at 2pm.",
                    Priority = "1",
                    Author = "Alan Turing",
                    Project = "Draw Draw On the Go",
                    CreationDate = DateTime.Parse("2020-2-20"),
                    Developer = "Albert Einstein",
                    Status = "Pending"
                },
                new Issue
                {
                    Title = "File Save Corruption",
                    Description = "Saved file data periodically becomes corrupted.",
                    Priority = "1",
                    Author = "Albert Einstein",
                    Project = "Public Transportation App",
                    CreationDate = DateTime.Parse("2020-2-10"),
                    Developer = "Prim",
                    Status = "Pending"
                },
                new Issue
                {
                    Title = "Chinese Language Support",
                    Description = "The product is being sold to customers in China, but Chinese character support needs to be added.",
                    Priority = "3",
                    Author = "Djikstra",
                    Project = "Falcon Videogame",
                    CreationDate = DateTime.Parse("2020-4-20"),
                    Developer = "Kruskal",
                    Status = "Pending"
                }
            );
            context.SaveChanges();
        }
    }
}
}
