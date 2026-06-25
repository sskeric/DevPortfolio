using System.ComponentModel.DataAnnotations;

namespace DevPortfolio.Models;

public class ContactMessage
{
    [Required(ErrorMessage = "Please enter your name.")]
    public string Name { get; set; } = "";

    [Required(ErrorMessage = "Please enter your email.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Please add a subject.")]
    public string Subject { get; set; } = "";

    [Required(ErrorMessage = "Please write a message.")]
    [MinLength(10, ErrorMessage = "Message should be at least 10 characters.")]
    public string Message { get; set; } = "";
}
