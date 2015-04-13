using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuizService.Models
{
    public class AnswerOptions
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}