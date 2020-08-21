using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Application_Issue_Tracker.Models
{
    public class Issue
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [StringLength(60, MinimumLength = 10)]
        [Required]
        public string Description { get; set; }
        [Range(1,3)]
        public string Priority { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Project { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Author { get; set; }

        [Display(Name = "Creation Date")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string  Developer{ get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string  Status{ get; set; }
    }
}