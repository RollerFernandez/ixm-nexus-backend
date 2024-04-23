namespace Ixm.Nexus.Users.Application.Implementations;
public class SecurityService : ISecurityService
{
    public bool VerifyHashedPassword(string email, string hashedPassword, string providedPassword) {
        PasswordHasher<string> passwordHasher = new();
        PasswordVerificationResult result = passwordHasher.VerifyHashedPassword(email, hashedPassword, providedPassword);
        return result == PasswordVerificationResult.Success;
    }

    public SecurityDto JwtSecurity(string jwtSecrectKey, string email) { 
        DateTime nowUtc = DateTime.UtcNow;

        List<Claim> claims = [ 
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Iat, nowUtc.ToString()),
            new Claim(JwtRegisteredClaimNames.Email, email)
        ];

        DateTime expireDateTime = nowUtc.AddDays(1);

        JwtSecurityTokenHandler handler = new();

        byte[] key = Encoding.ASCII.GetBytes(jwtSecrectKey);
        SymmetricSecurityKey symmetricSecurityKey = new(key);
        SigningCredentials signingCredentials = new(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

        JwtSecurityToken jwtSecurityToken = new(
            claims: claims,
            expires: expireDateTime,
            notBefore: nowUtc,
            signingCredentials: signingCredentials
            );

        return new()
        {
            TokenType = "Bearer",
            AccessToken = handler.WriteToken(jwtSecurityToken),
            ExpireOn = expireDateTime
        };
    }
}
