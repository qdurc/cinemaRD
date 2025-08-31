namespace cinemaRD.Api.Integration;

//Clase donde se deserializa el JSON (Propiedades iguales)
public record class TmdbMovie
{
    public bool adult { get; init; }
    public string? backdrop_path { get; init; }
    public IReadOnlyList<int> genre_ids { get; init; } = Array.Empty<int>();
    public int id { get; init; }
    public string? original_language { get; init; }
    public string? original_title { get; init; }
    public string? overview { get; init; }
    public double popularity { get; init; }
    public string? poster_path { get; init; }
    public string? release_date { get; init; }
    public string? title { get; init; }
    public bool video { get; init; }
    public double vote_average { get; init; }
    public int vote_count { get; init; }
}

