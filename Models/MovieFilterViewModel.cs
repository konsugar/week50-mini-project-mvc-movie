using Microsoft.AspNetCore.Mvc.Rendering;
//using System.Collections.Generic;

namespace week50_mini_project_mvc_movie.Models
{
    public class MovieFilterViewModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList Genres { get; set; }
        public string SelectedGenre { get; set; }
        public string SearchString { get; set; }
    }
}
