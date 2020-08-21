using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Web_Application_Issue_Tracker.Models
{
    public class IssueProjectViewModel
    {
        public List<Issue> Issues { get; set; }
        public SelectList Projects { get; set; }
        public string IssueProject { get; set; }
        public string SearchString { get; set; }
    }
}
