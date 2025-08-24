using System.ComponentModel.DataAnnotations;

namespace eCommerce.WebApi.Models;

public record ProductCreateDto(
    [Required] string Name,
    [Required] decimal Price);