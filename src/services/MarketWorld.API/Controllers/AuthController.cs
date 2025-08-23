using MarketWorld.Application.Services.Jwt;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MarketWorld.API.Models.Auth;
using System.Linq;
using System;
using MarketWorld.Core.Domain.Entities;

namespace MarketWorld.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : BaseController
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly IJwtService _jwtService;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly IConfiguration _configuration;

    public AuthController(
        UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager,
        IJwtService jwtService,
        RoleManager<IdentityRole> roleManager,
        IConfiguration configuration)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _jwtService = jwtService;
        _roleManager = roleManager;
        _configuration = configuration;
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
            // Kullanıcıya rol atama
            var role = await _roleManager.FindByIdAsync(model.RoleId);
            
            if (role != null)
            {
                await _userManager.AddToRoleAsync(user, role.Name);
                return Ok(new { Message = "Kullanıcı başarıyla oluşturuldu." });
            }
            else
            {
                return BadRequest(new { Message = "Belirtilen rol bulunamadı." });
            }
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
            
            // Token'ın sona erme süresini al (appsettings'deki değere göre)
            var expiresInMinutes = Convert.ToDouble(_configuration["Jwt:DurationInMinutes"]);
            var expiresAt = DateTime.Now.AddMinutes(expiresInMinutes);
            
            var tokenResponse = new TokenResponse
            {
                Token = token,
                ExpiresAt = expiresAt,
            };
            
            return Ok(tokenResponse);
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
    
    [HttpGet("roles")]
    public async Task<IActionResult> GetRoles()
    {
        var roles = _roleManager.Roles
            .Select(r => new { Id = r.Id, Name = r.Name })
            .ToList();
            
        return Ok(roles);
    }
}
