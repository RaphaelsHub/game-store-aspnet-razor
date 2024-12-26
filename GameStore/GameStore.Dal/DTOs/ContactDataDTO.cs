using System.ComponentModel.DataAnnotations;

namespace GameStore.Dal.DTOs;

public class ContactDataDTO
{
    [Required]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters.")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Surname must be between 2 and 50 characters.")]
    public string Surname { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    [StringLength(100, ErrorMessage = "Email must be up to 100 characters.")]
    public string Email { get; set; } = string.Empty;

    [Required]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Subject must be between 2 and 100 characters.")]
    public string Subject { get; set; } = string.Empty;

    [Required]
    [StringLength(500, MinimumLength = 10, ErrorMessage = "Message must be between 10 and 500 characters.")]
    public string Message { get; set; } = string.Empty;
}