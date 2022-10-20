using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IMovieDal
    {

        MovieModel? GetById(int MovieId);
        List<MovieModel> GetAll();

        int CreateMovie(MovieModel Movie);
        void UpdateMovie(MovieModel Movie);
        void DeleteMovie(int MovieId);
    }
}
