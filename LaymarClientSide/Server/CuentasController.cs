using LaymarClientSide.Server.Context;
using LaymarClientSide.Shared;
using LaymarClientSide.Shared.Entidades;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LaymarClientSide.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentasController : ControllerBase
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _context;
        public CuentasController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IConfiguration configuration, ApplicationDbContext context)

        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _context = context;
        }

        [HttpPost("Crear")]
        public async Task<ActionResult<UserInfo>> CreateUser(UserInfo model)
        {
            var user = new IdentityUser { UserName = model.username, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                foreach (var rol in model.roles)
                {

                    await _userManager.AddToRoleAsync(user, rol.rol);
                }

                foreach (Sucursal sucursal in model.sucursales)
                {
                    _context.userSucursal.Add(new UserSucursal
                    {
                        sucursal = await _context.sucursal.FirstAsync(x => x.SucursalId == sucursal.SucursalId),
                        userName = model.username
                    });
                }
                await _context.SaveChangesAsync();
                return model;


            }
            else

            {
                return BadRequest("Username or password invalid");
            }

        }

        [HttpGet("UserSucursal/{userName}")]
        public async Task<List<Sucursal>> UserSucursal(string userName)
        {
            List<Sucursal> sucursales = new List<Sucursal>();
            List<UserSucursal> userSucursals = await _context.userSucursal.Include(x => x.sucursal).Where(x => x.userName == userName && x.sucursal.fechaBaja == null).ToListAsync();
            foreach (UserSucursal userSucursal in userSucursals)
            {

                sucursales.Add(userSucursal.sucursal);

            }

            return sucursales;
        }
        [HttpPost("CambiarContraseña")]
        public async Task CambiarContraseña(UserInfo userInfo)
        {

            IdentityUser user = await _context.Users.SingleAsync(w => w.UserName == userInfo.username);
            try
            {
                await _userManager.RemovePasswordAsync(user);
                await _userManager.AddPasswordAsync(user, userInfo.Password);
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        [HttpGet("ultimaEntrada/{userName}")]
        public async Task<UserEntradas> UltimaSucursal(string userName)
        {

            UserEntradas ultimaEntrada;
            try
            {
                ultimaEntrada = await _context.userEntradas.Include(x => x.sucursal)
                    .Where(x => String.Equals(userName, x.userName))
                    .OrderByDescending(x => x.UserEntradasId).Take(1).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
            return ultimaEntrada;
        }


        [HttpPost("cambiarSucusal")]
        public async Task<UserEntradas> cambiarSucusal([FromBody] UserEntradas userEntradas)
        {

            userEntradas.sucursal = await _context.sucursal.FindAsync(userEntradas.sucursal.SucursalId);
            _context.userEntradas.Add(userEntradas);



            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return userEntradas;

        }

        [HttpPost("PreLogin")]
        public async Task<ActionResult<bool>> PreLogin([FromBody] UserInfo userInfo)
        {
            var result = await _signInManager.PasswordSignInAsync(userInfo.username, userInfo.Password, isPersistent: false, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return true;
            }
            else { return false; }
        }

        [HttpPost("Login/{sucursalId}")]
        public async Task<ActionResult<UserToken>> Login(int sucursalId, [FromBody] UserInfo userInfo)
        {
            var result = await _signInManager.PasswordSignInAsync(userInfo.username, userInfo.Password, isPersistent: false, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                await cambiarSucusal(new UserEntradas { userName = userInfo.username, sucursal = await _context.sucursal.FindAsync(sucursalId) });
                return await BuildToken(userInfo);
            }
            else
            {
                Console.WriteLine("Error");
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return BadRequest("Username or password invalid");
            }
        }

        private async Task<UserToken> BuildToken(UserInfo userInfo)
        {
            IdentityUser user = await _context.Users.SingleAsync(w => w.UserName == userInfo.username);
            var roles = await _context.UserRoles.Where(x => x.UserId == user.Id).ToListAsync();
            List<Claim> claims = new List<Claim> {

        new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.Email),
        new Claim(ClaimTypes.Name, userInfo.username),

        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
    };
            foreach (var r in roles)
            {

                claims.Add(new Claim(ClaimTypes.Role, r.RoleId));
            }


            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Tiempo de expiración del token. En nuestro caso lo hacemos de una hora.
            var expiration = DateTime.Now.AddHours(-3).AddHours(1);

            JwtSecurityToken token = new JwtSecurityToken(
               issuer: null,
               audience: null,
               claims: claims,
               expires: expiration,
               signingCredentials: creds);

            return new UserToken()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration
            };
        }

        [HttpGet("Roles")]

        public async Task<ActionResult<List<Roles>>> getroles()
        {
            List<Roles> roles = new List<Roles>();
            var res = await _context.Roles.ToListAsync();

            for (int i = 0; i < res.Count(); i++)
            {

                roles.Add(new Roles { id = res[i].Id, rol = res[i].Name });
            }

            return roles;
        }

        [HttpGet("Usuarios")]

        public async Task<ActionResult<List<UserInfo>>> getUsuarios()
        {

            List<UserInfo> users = new List<UserInfo>();
            var res = await _context.Users.ToListAsync();
            List<Roles> roles1 = new List<Roles>();
            List<Sucursal> sucursales = new List<Sucursal>();
            foreach (IdentityUser identity in res)
            {
                List<string> roles = await _userManager.GetRolesAsync(identity) as List<string>;
                roles1 = new List<Roles>();
                sucursales = new List<Sucursal>();

                foreach (string rol in roles)
                {
                    roles1.Add(new Roles { id = rol, rol = rol });
                }

                foreach (Sucursal sucursal in await UserSucursal(identity.UserName))
                {
                    sucursales.Add(sucursal);
                }

                users.Add(new UserInfo
                {
                    Email = identity.Email,
                    username = identity.UserName,
                    id = identity.Id,
                    roles = roles1,
                    sucursales = sucursales
                });

            }


            return users;
        }

        [HttpPut("Editar/{id}")]
        public async Task<UserInfo> Editar(string id, [FromBody] UserInfo userInfo)
        {
            IdentityUser identityUser = await _userManager.FindByIdAsync(id);
            identityUser.UserName = userInfo.username;
            identityUser.Email = userInfo.Email;
            List<string> rolesDelUsuario = await _userManager.GetRolesAsync(identityUser) as List<string>;

            List<UserSucursal> userSucursales = await _context.userSucursal.Where(x => x.userName == userInfo.username).ToListAsync();
            List<Sucursal> sucursales = await _context.sucursal.ToListAsync();

            _context.userSucursal.RemoveRange(userSucursales);
            foreach (Sucursal sucursal in userInfo.sucursales)
            {
                _context.userSucursal.Add(new UserSucursal
                {
                    sucursal = await _context.sucursal.FirstAsync(x => x.SucursalId == sucursal.SucursalId),
                    userName = userInfo.username
                });

            }

            foreach (string rolAEliminar in rolesDelUsuario)
            {
                await _userManager.RemoveFromRoleAsync(identityUser, rolAEliminar);
            }

            foreach (Roles rol in userInfo.roles)
            {

                await _userManager.AddToRoleAsync(identityUser, rol.rol);
            }

            return userInfo;
        }

        [HttpPost("EliminarUsuario/{id}")]
        public async Task EliminarUsuario(string id)
        {
            IdentityUser identityUser = await _userManager.FindByIdAsync(id);
            await _userManager.DeleteAsync(identityUser);
        }
    }
}
