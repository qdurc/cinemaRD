using cinemaRD.Api.Dtos;

namespace cinemaRD.Api.Services;

public class TmdService(IHttpClientFactory httpClientFactory) : ITmdbService
{
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient("tmdb");

    public async Task<MovieSummaryDto?> GetTopRatedMovies()
    {
        var url = "movie/top_rated?language=es-ES&page=1";
        var res = await _httpClient.GetAsync(url);
        if (!res.IsSuccessStatusCode)
            return null;

        var pagedResult = await res.Content.ReadFromJsonAsync<PagedResult<MovieSummaryDto>>();
        return pagedResult?.Results.FirstOrDefault();
    }

    public async Task<PagedResult<MovieSummaryDto>?> SearchMovies(string query, int page = 1)
    {
        if (string.IsNullOrWhiteSpace(query))
            return null;

        var url = $"search/movie?query={Uri.EscapeDataString(query)}&include_adult=false&language=es-ES&page={page}";
        var res = await _httpClient.GetAsync(url);
        if (!res.IsSuccessStatusCode)
            return null;

        //Deserializo el JSON y lo devuelvo
        return await res.Content.ReadFromJsonAsync<PagedResult<MovieSummaryDto>>();
    }
}
