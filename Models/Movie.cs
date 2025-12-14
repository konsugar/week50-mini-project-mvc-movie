using System.ComponentModel.DataAnnotations;

namespace week50_mini_project_mvc_movie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Genre { get; set; }

        [Range(0, 1000)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
