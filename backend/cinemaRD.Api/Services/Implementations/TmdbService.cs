using cinemaRD.Api.Dtos;

namespace cinemaRD.Api.Services;

public class TmdbService : ITmdbService
{
    private readonly HttpClient _http;

    public TmdbService(IHttpClientFactory factory)
    {
        _http = factory.CreateClient("tmdb");
    }

    public async Task<MovieSummaryDto?> GetTopRatedMovies()
    {
        var url = $"movie/top_rated?&language=es-ES&page=1";
        var res = await _http.GetAsync(url);

        if (!res.IsSuccessStatusCode)
        {
            var msg = await res.Content.ReadAsStringAsync();
            Console.WriteLine($"TMDB ERROR {res.StatusCode}: {msg}");
            return null;
        }

        var pagedResult = await res.Content.ReadFromJsonAsync<PagedResult<MovieSummaryDto>>();
        return pagedResult?.Results.FirstOrDefault();
    }

    public Task<PagedResult<MovieSummaryDto>?> SearchMovies(string query, int page = 1)
    {
        throw new NotImplementedException();
    }
}
