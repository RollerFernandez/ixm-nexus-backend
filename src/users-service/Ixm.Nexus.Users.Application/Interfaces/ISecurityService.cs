namespace Ixm.Nexus.Users.Application.Interfaces;
public interface ISecurityService
{
    bool VerifyHashedPassword(string email, string hashedPassword, string providedPassword);
    SecurityDto JwtSecurity(string jwtSecrectKey, string email);
}
