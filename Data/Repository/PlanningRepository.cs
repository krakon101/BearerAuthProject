using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public interface IPlanningRepository
    {
        public void AddPlanning(Planning plan);
        public List<Planning> ShowPlanByMovie(long movieId);
        public List<Planning> ShowPlanByTheatre(long theatreId);
        public Planning UpdatePlanning(Planning planning);
        public void DeletePlanning(Planning planning);
    }
    public class PlanningRepository : IPlanningRepository
    {
        public readonly Context _context;

        public PlanningRepository(Context context)
        {
            _context = context;
        }

        public void AddPlanning(Planning plan)
        {
            _context.Plannings.Add(plan);
        }

        public void DeletePlanning(Planning planning)
        {
            _context.Plannings.Remove(planning);
        }

        public List<Planning> ShowPlanByMovie(long movieId)
        {
            return _context.Plannings.Where(x => x.MovieId == movieId).ToList();
        }

        public List<Planning> ShowPlanByTheatre(long theatreId)
        {
            return _context.Plannings.Where(x => x.TheatreId == theatreId).ToList();
        }

        public Planning UpdatePlanning(Planning planning)
        {
            var index = _context.Plannings.IndexOf(planning);

            _context.Plannings[index].SeatsAvailable = planning.SeatsAvailable;

            return _context.Plannings[index];
        }
    }
}
