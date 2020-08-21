using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using MobileApp.Models;

namespace MobileApp.Data
{
    public class IssueDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public IssueDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Issue>().Wait();
        }

        public Task<List<Issue>> GetMobileAppAsync()
        {
            return _database.Table<Issue>().ToListAsync();
        }

        public Task<Issue> GetIssueAsync(int id)
        {
            return _database.Table<Issue>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveIssueAsync(Issue issue)
        {
            if (issue.ID != 0)
            {
                return _database.UpdateAsync(issue);
            }
            else
            {
                return _database.InsertAsync(issue);
            }
        }

        public Task<int> DeleteIssueAsync(Issue issue)
        {
            return _database.DeleteAsync(issue);
        }
    }
}