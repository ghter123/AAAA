using System.Collections.Generic;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;
using AAAA.Domain.Interfaces;

namespace AAAA.Domain.Services
{
    public class TokenConfig
    {
        public string SecurityKey { get; set; }
        public int Expires { get; set; }
        public int RefreshExpires { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }

    public class TokenService : ITokenService
    {
        private readonly TokenConfig _tokenConfig;

        public TokenService(TokenConfig tokenConfig)
        {
            _tokenConfig = tokenConfig;
        }

        public IEnumerable<Claim> Authenticate(string token)
        {
            var jwtSecurityToken = new JwtSecurityToken(token);
            return jwtSecurityToken.ValidTo < DateTime.UtcNow ? jwtSecurityToken.Claims : null;
        }

        public string Create(IEnumerable<Claim> claims)
        {
            var issuer = _tokenConfig.Issuer;
            var audience = _tokenConfig.Audience;
            var expires = DateTime.UtcNow.AddMilliseconds(_tokenConfig.Expires);
            var signingCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenConfig.SecurityKey)), SecurityAlgorithms.HmacSha256Signature);

            return new JwtSecurityToken(issuer, audience, claims, null, expires, signingCredentials).ToString();
        }

        public string Refresh(string token)
        {
            var jwtSecurityToken = new JwtSecurityToken(token);
            var refreshExpireTime = jwtSecurityToken.ValidFrom.AddMilliseconds(_tokenConfig.RefreshExpires);
            if (DateTime.UtcNow > refreshExpireTime) return null;

            Deactivate(token);

            return Create(jwtSecurityToken.Claims);
        }

        public void Deactivate(string token)
        {

        }
    }
}
