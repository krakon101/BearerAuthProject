using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IUnitOfWork : IDisposable
    {
        IMovieRepository MovieRepository { get; }
        ITheatreRepository TheatreRepository { get; }
        IPlanningRepository PlanningRepository { get; }
    }
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;

        public UnitOfWork(Context context) { _context = context; }
        
        private MovieRepository _movieRepository;
        private TheatreRepository _theatreRepository;
        private PlanningRepository _planningRepository;

        public IMovieRepository MovieRepository { get { return _movieRepository??= new MovieRepository(_context); } }
        public ITheatreRepository TheatreRepository { get { return _theatreRepository??= new TheatreRepository(_context); } }
        public IPlanningRepository PlanningRepository { get { return _planningRepository??= new PlanningRepository(_context); } }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
