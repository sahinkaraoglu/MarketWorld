using MarketWorld.Domain.Entities;
using MarketWorld.Application.Services.Jwt;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MarketWorld.API.Models.Auth;
using MarketWorld.API.Controllers;
using MarketWorld.Api.Controllers;

namespace MarketWorld.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : BaseController
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly IJwtService _jwtService;
    private readonly RoleManager<IdentityRole> _roleManager;

    public AuthController(
        UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager,
        IJwtService jwtService,
        RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _jwtService = jwtService;
        _roleManager = roleManager;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterModel model)
    {
        var user = new ApplicationUser
        {
            Email = model.Email,
            UserName = model.UserName,
            FirstName = model.FirstName,
            LastName = model.LastName,
            PhoneNumber = model.PhoneNumber
        };

        var result = await _userManager.CreateAsync(user, model.Password);

        if (result.Succeeded)
        {
            // RoleId değerine göre rol atama
            string roleName = model.RoleId == 1 ? "Admin" : "User";
            
            // Rol varsa kullanıcıya ekle
            if (await _roleManager.RoleExistsAsync(roleName))
            {
                await _userManager.AddToRoleAsync(user, roleName);
            }
            // Rol yoksa önce oluştur sonra ekle
            else
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName));
                await _userManager.AddToRoleAsync(user, roleName);
            }
            
            return Ok(new { Message = "Kullanıcı başarıyla oluşturuldu." });
        }

        return BadRequest(new { Errors = result.Errors });
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginModel model)
    {
        var user = await _userManager.FindByEmailAsync(model.Email);
        if (user == null)
        {
            return BadRequest(new { Message = "Email veya şifre hatalı." });
        }

        var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);

        if (result.Succeeded)
        {
            var token = _jwtService.GenerateToken(user.Id, user.Email!, user.UserName!);
            return Ok(new { Token = token });
        }

        return BadRequest(new { Message = "Email veya şifre hatalı." });
    }

    [HttpGet("admin")]
    [Authorize]
    public async Task<IActionResult> Admin()
    {
        var userId = GetUserId();
        return Ok(new
        {
            userId = userId
        });
    }
}
