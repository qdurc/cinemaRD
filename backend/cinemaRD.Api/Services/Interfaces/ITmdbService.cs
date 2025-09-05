using cinemaRD.Api.Dtos;

namespace cinemaRD.Api.Services;

public interface ITmdbService
{
    Task<MovieSummaryDto?> GetTopRatedMovies();
    Task<PagedResult<MovieSummaryDto>?> SearchMovies(string query, int page = 1);
}
