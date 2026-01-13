using Microsoft.AspNetCore.Mvc.Rendering;

namespace Week02.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie>? Movies { get; set; }
        public SelectList? Genres { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
        public int? FromYear { get; set; }
    }
}
