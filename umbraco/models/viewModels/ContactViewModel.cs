using System.ComponentModel.DataAnnotations;

public class ContactViewModel
{
    [Required(ErrorMessage="Please enter your name"),MaxLength(50)]
    [DataType(DataType.Text)]
    public string? Name { get; set; }
    [Required][RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Your Email is not valid.")]
    public string? Email { get; set; }
    [DataType(DataType.PhoneNumber)]
    public string? Phone { get; set; }
    [Required][DataType(DataType.MultilineText)]
    public string? Message { get; set; } 
}