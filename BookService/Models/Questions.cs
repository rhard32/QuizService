using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QuizService.Models
{
    public class Questions
    {
        public int Id { get; set; }

        [Required]
        public string Question { get; set; }
    }
}
