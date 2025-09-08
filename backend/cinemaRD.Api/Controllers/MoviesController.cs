using System.Net;
using cinemaRD.Api.Dtos;
using cinemaRD.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic.FileIO;

namespace cinemaRD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController(ITmdbService tmdb, ILogger<MoviesController> logger) : ControllerBase
    {
        private readonly ITmdbService _tmdb = tmdb;
        private readonly ILogger<MoviesController> _logger = logger;

        [HttpGet("top-rated")]
        [ProducesResponseType(typeof(MovieSummaryDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.BadGateway)]
        [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any, NoStore = false)]
        public async Task<ActionResult<MovieSummaryDto>> GetTopRated(CancellationToken ct)
        {
            try
            {
                var movie = await _tmdb.GetTopRatedMovies();
                if (movie is null)
                    return StatusCode((int)HttpStatusCode.BadGateway);

                return Ok(movie);
            }
            catch (OperationCanceledException)
            {
                _logger.LogWarning("Solicitud cancelada en GET /api/movies/top-rated");
                return Problem(statusCode: (int)HttpStatusCode.RequestTimeout, title: "Operación cancelada");
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "Error al consultar TMDB para Top Rated");
                return StatusCode((int)HttpStatusCode.BadGateway, "Error consultando servicio externo");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error inesperado en Top Rated");
                return StatusCode((int)HttpStatusCode.InternalServerError, "Error interno");
            }
        }

    }
}
