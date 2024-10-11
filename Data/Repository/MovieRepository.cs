using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public interface IMovieRepository
    {
        public Movie GetById(long id);
        public List<Movie> GetAll();
        public bool Add(Movie movie);
        public bool Delete(long id);
    }
    public class MovieRepository : IMovieRepository
    {
        public readonly Context _context;
        public MovieRepository(Context context)
        {
            _context = context;
        }

        public Movie GetById(long id)
        {
            return _context.Movies.First(x => x.Id == id);
        }

        public List<Movie> GetAll()
        {
            return _context.Movies.ToList();
        }

        public bool Add(Movie movie) 
        {
            try
            {
                _context.Movies.Add(movie);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool Delete(long id) 
        {
            _context.Movies.Remove(GetById(id));
            return true;
        }
    }
}
