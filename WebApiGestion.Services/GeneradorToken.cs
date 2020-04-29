namespace WebApiGestion.Services
{
    using Microsoft.IdentityModel.Tokens;
    using System;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;

    public class GeneradorToken : IGeneradorToken
    {
        public string GenerarToken(Dtos.DatosLoginDto dto)
        {
            var _symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(dto.Secret));
            var _signingCredentials = new SigningCredentials(_symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            var _Header = new JwtHeader(_signingCredentials);

            var _Claims = new[] {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.NameId, dto.IdUsuario.ToString()),
            };

            var _Payload = new JwtPayload(
                   issuer: dto.Issuer,
                   audience: dto.Audience,
                   claims: _Claims,
                   notBefore: DateTime.UtcNow,
                   // Exipra a la 24 horas.
                   expires: DateTime.UtcNow.AddHours(24)
               );

            var _Token = new JwtSecurityToken(
              _Header,
              _Payload
          );

            return new JwtSecurityTokenHandler().WriteToken(_Token);
        }
    }
}