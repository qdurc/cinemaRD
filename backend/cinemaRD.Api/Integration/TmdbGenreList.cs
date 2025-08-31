namespace cinemaRD.Api.Integration;
// {
//   "genres": [
//     { "id": 878, "name": "Ciencia ficción" },
//     { "id": 53, "name": "Suspenso" }
//   ]
// }

public record class TmdbGenreList
{
    public IReadOnlyList<TmdbGenre> genres { get; init; } = Array.Empty<TmdbGenre>();
}
