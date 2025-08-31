namespace cinemaRD.Api.Integration;

public record class TmdbPagedResult<T>
{
    public int page { get; init; }
    public int total_pages { get; init; }
    public int total_results { get; init; }
    public IReadOnlyList<T> results { get; init; } = Array.Empty<T>();
}
