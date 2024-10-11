using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public interface ITheatreRepository
    {
        public Theatre GetById(long id);
        public List<Theatre> GetAll();
        public bool Add(Theatre theatre);
        public bool Delete (long id);
    }
    public class TheatreRepository : ITheatreRepository
    {
        public readonly Context _context;
        public TheatreRepository(Context context)
        {
            _context = context;
        }
        public bool Add(Theatre theatre)
        {
            try
            {
                _context.Theatres.Add(theatre);
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }

        public bool Delete(long id)
        {
            _context.Theatres.Remove(GetById(id));
            return true;
        }

        public List<Theatre> GetAll()
        {
            return _context.Theatres;
        }

        public Theatre GetById(long id)
        {
            return _context.Theatres.First(x => x.Id == id);
        }
    }
}
