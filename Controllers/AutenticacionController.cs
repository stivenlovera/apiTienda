using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using apiTienda.Dto.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace apiTienda.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AutenticacionController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AutenticacionController(UserManager<IdentityUser> userManager, IConfiguration configuration, SignInManager<IdentityUser> signInManager)
        {
            this._userManager = userManager;
            this._configuration = configuration;
            this._signInManager = signInManager;
        }
        [HttpPost("registrar")]
        public async Task<ActionResult<RespuestaAutenticacionDto>> Registrar(Login login)
        {
            var usuario = new IdentityUser { UserName = login.Usuario, Email = login.Usuario };
            var resultado = await this._userManager.CreateAsync(usuario, login.Password);
            if (resultado.Succeeded)
            {
                return this.ConstruirToken(login);
            }
            else
            {
                return BadRequest(resultado.Errors);
            }
        }
        private RespuestaAutenticacionDto ConstruirToken(Login login)
        {
            var claims = new List<Claim>(){
                new Claim("usuario",login.Usuario)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this._configuration["jwt"]));
            var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiration = DateTime.UtcNow.AddYears(1);
            var securityToken = new JwtSecurityToken(
                issuer: null,
                audience: null,
                claims: claims,
                expires: expiration,
                signingCredentials: credential
                );
            return new RespuestaAutenticacionDto
            {
                Token = new JwtSecurityTokenHandler().WriteToken(securityToken),
                Expiration = expiration
            };
        }
        [HttpPost("login")]
        public async Task<ActionResult<RespuestaAutenticacionDto>> Login(Login login)
        {
            var resultado = await this._signInManager.PasswordSignInAsync(
                login.Usuario, login.Password, isPersistent: false, lockoutOnFailure: false
            );
            if (resultado.Succeeded)
            {
                return this.ConstruirToken(login);
            }
            else
            {
                return BadRequest("login incorrecto");
            }
        }
    }
}