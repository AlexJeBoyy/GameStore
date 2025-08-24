using System.ComponentModel.DataAnnotations;

namespace GameStore.Api.Dtos;

public record class CreateGameDto(
    [Required][StringLength(50)] string Name,
    [Required] int GenreId,
    [Range(0, 200)] decimal Price,
    DateOnly ReleaseDate
    );

