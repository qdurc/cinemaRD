namespace cinemaRD.Api.Dtos;

// Card en el front
public record class MovieSummaryDto
{
    public int Id { get; init; }
    public string Title { get; init; } = "";
    public int? Year { get; init; }
    public string? PosterUrl { get; init; }
    public double Rating { get; init; }
    public IReadOnlyList<string> Genres { get; init; } = Array.Empty<string>();
}
