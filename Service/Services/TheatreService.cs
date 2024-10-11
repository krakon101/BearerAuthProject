using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public interface ITheatreService
    {

    }
    public class TheatreService : ITheatreService
    {
        public readonly IUnitOfWork _unitOfWork;

        public TheatreService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
