
using _1CommonInfrastructure.Models;

namespace WebApplication3tierApp.Models
{
  
        public class MovieDto
        {
        public int MovieId { get; set; } 
        public string MovieName { get; set; } 
        public string Director { set; get; }
        public DateTime ReleaseDate { set; get; }

        public string Brief { set; get; }

    }

        public static class MovieDtoMapExtensions
        {
            public static MovieDto ToMovieDto(this MovieModel src)
            {
                var dst = new MovieDto();
                dst.MovieId = src.MovieId;
                dst.MovieName = src.MovieName;
                dst.Director = src.Director;
                dst.ReleaseDate = src.ReleaseDate;
                dst.Brief = src.Brief;
            return dst;
            }

            public static MovieModel ToMovieModel(this MovieDto src)
            {
                var dst = new MovieModel();
                dst.MovieId = src.MovieId;
                dst.MovieName = src.MovieName;
                dst.Director = src.Director;
                dst.ReleaseDate = src.ReleaseDate;
                dst.Brief = src.Brief;
            return dst;
            }
        }
    
}
