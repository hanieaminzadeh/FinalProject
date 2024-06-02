namespace HomeService.Core.DTOs;

public class ApplicationUserDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Email { get; set; } = string.Empty;
    public string? Password { get; set; } = string.Empty;
    public string? UserName { get; set; } = string.Empty;
    public string ProfileImgUrl { get; set; }
    public string? ConfirmPassword { get; set; } = string.Empty;
    public string? Role { get; set; }
}
