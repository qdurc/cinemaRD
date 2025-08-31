namespace cinemaRD.Api.Dtos;

// Card en el front
public record class MovieSummaryDto
{
    public int Id { get; init; }                 // TMDb Id
    public string Title { get; init; } = "";     // Título limpio
    public int? Year { get; init; }              // Derivado de release_date
    public string? PosterUrl { get; init; }      // Construido con base https://image.tmdb.org/t/p/w500
    public double Rating { get; init; }          // vote_average
    public IReadOnlyList<string> Genres { get; init; } = Array.Empty<string>(); // traducidos con genre/list
}



    



