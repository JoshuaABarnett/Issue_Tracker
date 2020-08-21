using System;
using SQLite;

namespace MobileApp.Models
{
    public class Issue
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        public string Priority { get; set; }
        public string Project { get; set; }
        public string Author { get; set; }

        public DateTime CreationDate { get; set; }
        public string  Developer{ get; set; }
        public string  Status{ get; set; }
    }
}