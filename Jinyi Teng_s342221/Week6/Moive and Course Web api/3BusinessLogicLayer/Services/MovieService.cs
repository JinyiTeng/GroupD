using System;
using _1CommonInfrastructure.Models;
using _2DataAccessLayer.Context.Models;
using _2DataAccessLayer.Interfaces;
using _3BusinessLogicLayer.Interfaces;
namespace _3BusinessLogicLayer.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieDal _MovieDal;
        public MovieService(IMovieDal MovieDal
        )
        {
            _MovieDal = MovieDal;
        }

        public async Task<MovieModel?> GetById(int MovieId)
        {
            return _MovieDal.GetById(MovieId);
        }

        public async Task<List<MovieModel>> GetAll()
        {
            return _MovieDal.GetAll();
        }

        public async Task<int> CreateMovie(MovieModel Movie)
        {

            var newMovieId = _MovieDal.CreateMovie(Movie);
            return newMovieId;
        }

        public async Task UpdateMovie(MovieModel Movie)
        {
            _MovieDal.UpdateMovie(Movie);
        }

        public async Task DeleteMovie(int MovieId)
        {
            try
            {

                _MovieDal.DeleteMovie(MovieId);
            }
            catch (Exception e)
            {
               
            }
        }
    }
}
