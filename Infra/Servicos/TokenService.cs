using Dominio.IRepositorios;
using Dominio.Modelos;
using Infra.Dtos;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Servicos
{
    public class TokenService
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public TokenService(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public static string ChavePrivada { get; set; } = Environment.GetEnvironmentVariable("ChavePrivadaJWT");

        public string GerarToken(UsuarioDto usuarioDto)
        {
            var usuarioNoBanco = _usuarioRepositorio.ObterPeloUserNameCompleto(usuarioDto.UserName);
            if (usuarioNoBanco is null || usuarioNoBanco.Senha != usuarioDto.Senha) return String.Empty;

            var handler = new JwtSecurityTokenHandler();
            var chave = Encoding.ASCII.GetBytes(ChavePrivada);
            var credenciais = new SigningCredentials(new SymmetricSecurityKey(chave), SecurityAlgorithms.HmacSha256Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = GerarClaims(usuarioNoBanco),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = credenciais
            };

            var token = handler.CreateToken(tokenDescriptor);
            return handler.WriteToken(token);
        }

        private static ClaimsIdentity GerarClaims(Usuario usuario)
        {
            var ci = new ClaimsIdentity();
            ci.AddClaim(new Claim(ClaimTypes.Name, usuario.Email));

            return ci;
        }
    }
}
