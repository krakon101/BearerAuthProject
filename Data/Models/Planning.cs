using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Planning
    {
        public long Id { get; set; }
        public long MovieId { get; set; }
        public long TheatreId { get; set; }
        public Movie Movie { get; set; }
        public Theatre Theatre { get; set; }
        public int SeatsAvailable { get; set; }
    }
}
