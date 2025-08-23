using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MarketWorld.Core.Domain.Entities;
using MarketWorld.Infrastructure.Context;
using MarketWorld.Web.Areas.Admin.Models.Panel;

namespace MarketWorld.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserController(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            var userViewModels = new List<UserViewModel>();
            
            foreach (var user in users)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                var roleName = userRoles.FirstOrDefault() ?? "Kullanıcı";
                
                userViewModels.Add(new UserViewModel
                {
                    Id = user.Id,
                    Username = user.UserName,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Role = roleName,
                    IsActive = user.IsActive,
                    RegistrationDate = user.CreateDate
                });
            }
            
            return View(userViewModels);
        }

        [HttpGet]
        [Route("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([FromBody] UserViewModel model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest(new { success = false, message = "Geçersiz veri" });
                }
                
                ModelState.Remove("Id");
                
                if (!ModelState.IsValid)
                {
                    var validationErrors = string.Join(", ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
                    return BadRequest(new { success = false, message = $"Geçersiz veri: {validationErrors}" });
                }
                
                var existingUser = await _userManager.FindByEmailAsync(model.Email);
                if (existingUser != null)
                {
                    return BadRequest(new { success = false, message = "Bu email adresi zaten kullanımda" });
                }
                
                existingUser = await _userManager.FindByNameAsync(model.Username);
                if (existingUser != null)
                {
                    return BadRequest(new { success = false, message = "Bu kullanıcı adı zaten kullanımda" });
                }
                
                if (string.IsNullOrEmpty(model.Password) || model.Password != model.ConfirmPassword)
                {
                    return BadRequest(new { success = false, message = "Şifreler eşleşmiyor" });
                }
                
                var user = new ApplicationUser
                {
                    UserName = model.Username,
                    Email = model.Email,
                    FirstName = model.FirstName ?? "",
                    LastName = model.LastName ?? "",
                    IsActive = model.IsActive,
                    EmailConfirmed = model.IsActive,
                    CreateDate = DateTime.Now
                };
                
                var result = await _userManager.CreateAsync(user, model.Password);
                
                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(model.Role))
                    {
                        model.Role = "User";
                    }
                    
                    var roleExists = await _roleManager.RoleExistsAsync(model.Role);
                    if (!roleExists)
                    {
                        await _roleManager.CreateAsync(new IdentityRole(model.Role));
                    }
                    
                    await _userManager.AddToRoleAsync(user, model.Role);
                    
                    return Json(new { success = true, message = "Kullanıcı başarıyla eklendi" });
                }
                
                var errorMessages = string.Join(", ", result.Errors.Select(e => e.Description));
                return BadRequest(new { success = false, message = errorMessages });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Sunucu hatası: {ex.Message}" });
            }
        }

        [HttpGet]
        [Route("Edit/{id}")]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var userRoles = await _userManager.GetRolesAsync(user);
            var roleName = userRoles.FirstOrDefault() ?? "User";

            var viewModel = new UserViewModel
            {
                Id = user.Id,
                Username = user.UserName,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Role = roleName,
                IsActive = user.IsActive
            };

            return View(viewModel);
        }

        [HttpPost]
        [Route("Edit")]
        public async Task<IActionResult> Edit([FromBody] UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { success = false, message = "Geçersiz veri" });
            }
            
            var user = await _userManager.FindByIdAsync(model.Id);
            
            if (user == null)
            {
                return NotFound(new { success = false, message = "Kullanıcı bulunamadı" });
            }
            
            var existingUser = await _userManager.FindByEmailAsync(model.Email);
            if (existingUser != null && existingUser.Id != model.Id)
            {
                return BadRequest(new { success = false, message = "Bu email adresi zaten kullanımda" });
            }
            
            existingUser = await _userManager.FindByNameAsync(model.Username);
            if (existingUser != null && existingUser.Id != model.Id)
            {
                return BadRequest(new { success = false, message = "Bu kullanıcı adı zaten kullanımda" });
            }
            
            user.UserName = model.Username;
            user.Email = model.Email;
            user.FirstName = model.FirstName ?? user.FirstName;
            user.LastName = model.LastName ?? user.LastName;
            user.IsActive = model.IsActive;
            user.EmailConfirmed = model.IsActive;
            
            if (!string.IsNullOrEmpty(model.Password))
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var passwordChangeResult = await _userManager.ResetPasswordAsync(user, token, model.Password);
                
                if (!passwordChangeResult.Succeeded)
                {
                    return BadRequest(new { success = false, message = "Şifre değiştirme işlemi başarısız: " + string.Join(", ", passwordChangeResult.Errors.Select(e => e.Description)) });
                }
            }
            
            var updateResult = await _userManager.UpdateAsync(user);
            
            if (!updateResult.Succeeded)
            {
                return BadRequest(new { success = false, message = "Kullanıcı güncelleme işlemi başarısız: " + string.Join(", ", updateResult.Errors.Select(e => e.Description)) });
            }
            
            var userRoles = await _userManager.GetRolesAsync(user);
            await _userManager.RemoveFromRolesAsync(user, userRoles);
            await _userManager.AddToRoleAsync(user, model.Role);
            
            return Json(new { success = true, message = "Kullanıcı başarıyla güncellendi" });
        }

        [HttpPost]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            
            if (user == null)
            {
                return NotFound(new { success = false, message = "Kullanıcı bulunamadı" });
            }
            
            var result = await _userManager.DeleteAsync(user);
            
            if (result.Succeeded)
            {
                return Json(new { success = true, message = "Kullanıcı başarıyla silindi" });
            }
            
            return BadRequest(new { success = false, message = "Kullanıcı silme işlemi başarısız: " + string.Join(", ", result.Errors.Select(e => e.Description)) });
        }
    }
}
