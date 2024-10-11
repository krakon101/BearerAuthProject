using Data;

namespace Service.Services
{
    public interface IMovieService
    {

    }
    public class MovieService : IMovieService
    {
        public readonly IUnitOfWork _unitOfWork;

        public MovieService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


    }
}
