using System.ComponentModel.DataAnnotations;

namespace EventPlanner.Models;

public class Registration
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required, StringLength(100)]
    public string AttendeeName { get; set; } = string.Empty;

    [Required, EmailAddress, StringLength(200)]
    public string Email { get; set; } = string.Empty;

    [Required]
    public Guid EventId { get; set; }
}