using cinemaRD.Api.Dtos;

namespace cinemaRD.Api.Services;

public interface ITmdbService
{
    Task<PagedResult<MovieSummaryDto>?> SearchMovies(string query, int page = 1);
}
