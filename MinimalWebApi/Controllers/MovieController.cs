using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace MinimalWebApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/moviemanagement/[controller]")]
    public class MovieController : ControllerBase
    {
    }
}
