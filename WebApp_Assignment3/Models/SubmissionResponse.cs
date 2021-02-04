using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_Assignment3.Models
{
    public class SubmissionResponse
    {
        [Required]
        public string Category { get; set; }

        [Required]
        public String Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public String Director { get; set; }

        [Required]
        public String Rating { get; set; }
        
        public bool Edited { get; set; }

        public String LentTo { get; set; }

        [StringLength(25)]
        public String Notes { get; set; }
    }
}
