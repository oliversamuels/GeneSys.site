using System.ComponentModel.DataAnnotations;
public class DemoViewModel
{
    [Required][DataType(DataType.Text)][Display(Name = "First Name")]
    public string? FName { get; set; }
    public string? LName { get; set; }
    [Required][Display(Name = "Official Email")]
    [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Your Email is not valid.")]
    public string? CompanyEmail { get; set; }
    [Required][DataType(DataType.Text)]
    public string? CompanyName { get; set; }
    [Required][DataType(DataType.PhoneNumber)]
    public string? Phone { get; set; }
    [Required][DataType(DataType.Text)]
    public string? Country { get; set; } 
}