namespace Ixm.Nexus.Users.Application.Dto.UsersDto;
public class SecurityDto
{
    public string TokenType { get; set; } = string.Empty;
    public string AccessToken {  get; set; } = string.Empty;
    public DateTime ExpireOn {  get; set; }
}
