namespace Ixm.Nexus.Users.Application.Dto.UsersDto;
public class UserDto
{
    public string Name { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? Phone { get; set; }

    public string AccessToken {  get; set; } = string.Empty;
    public DateTime ExpirationDate { get; set; }
}
