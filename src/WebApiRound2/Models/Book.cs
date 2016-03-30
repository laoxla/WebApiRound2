using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiRound2.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Title can't be empty!")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Author can't be empty!")]
        public string Author { get; set; }
        [Required(ErrorMessage ="Genre can't be empty!")]
        [RegularExpression(@"Sci Fi|Nonfiction|Fantasy|History|Medicine|Social Science")]
        public string Genre { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage ="Page Count can't be negative!")]
        public int PageCount { get; set; }
    }
}
