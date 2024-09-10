using GameStore.API.Dtos;
using GameStore.API.Entities;

namespace GameStore.API.Mapping;

public static class GenreMapping
{
    public static GenreDtos ToDto(this Genre genre)
    {
        return new GenreDtos(genre.Id, genre.Name);
    }
}
