using System.ComponentModel.DataAnnotations;

public class ContactViewModel
{
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Email { get; set; }
    public string? Phone { get; set; }
    [Required]
    public string? Message { get; set; }
}