using System.IdentityModel.Tokens.Jwt;
using webSecurityCsharp.Entitys;
namespace webSecurityCsharp.Security
{
    public class AuthentificationService()
    {
    }

    private string GenerateJwtToken(User user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Enconding.UTF8.Get



    }














}
