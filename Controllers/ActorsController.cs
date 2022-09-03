using Microsoft.AspNetCore.Mvc;
using MoviePro.Services.Interfaces;
using System.Threading.Tasks;

namespace MoviePro.Controllers
{
    public class ActorsController : Controller
    {

        private readonly IRemoteMovieServices _tmdbMovieService;
        private readonly IDataMappingService _mappingService;

        public ActorsController(IRemoteMovieServices tmdbMovieService, IDataMappingService mappingService)
        {
            _tmdbMovieService = tmdbMovieService;
            _mappingService = mappingService;
        }

        public async Task<IActionResult> Details(int id)
        {
            var actor = await _tmdbMovieService.ActorDetailAsync(id);
            actor = _mappingService.MapActorDetail(actor);
            return View(actor);
        }

    }
}
