using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Context
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public List<Theatre> Theatres { get; set; } = new List<Theatre>();
        public List<Planning> Plannings { get; set; } = new List<Planning>();
    }
}
