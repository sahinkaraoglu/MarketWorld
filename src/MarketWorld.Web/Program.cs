using MarketWorld.Application.Repositories;
using MarketWorld.Application.Services.Abstract;
using MarketWorld.Application.Services.Concrete;
using MarketWorld.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using MarketWorld.Web.Middleware;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using MarketWorld.Application.Services.Jwt;
using MarketWorld.Core.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using MarketWorld.Infrastructure.Context;
using MarketWorld.Application.Services.Jwt;
using MarketWorld.Infrastructure.Data.SeedData;
using MarketWorld.Web.Services.Api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Session hizmetini ekle
builder.Services.AddMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// HttpContext erişimi için
builder.Services.AddHttpContextAccessor();

// DbContext configuration
builder.Services.AddDbContext<MarketWorldDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Identity konfigürasyonu
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options => {
    // Password requirements
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 8;
    
    // Lockout settings
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
    options.Lockout.MaxFailedAccessAttempts = 5;
    
    // User settings
    options.User.RequireUniqueEmail = true;
})
.AddEntityFrameworkStores<MarketWorldDbContext>()
.AddDefaultTokenProviders();

// JWT için konfigürasyon 
var jwtSection = builder.Configuration.GetSection("Jwt");
builder.Services.Configure<JwtOptions>(jwtSection);

// JWT Authentication ekle
var jwtSettings = jwtSection.Get<JwtOptions>();
var key = Encoding.ASCII.GetBytes(jwtSettings.Key);

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = true,
        ValidIssuer = jwtSettings.Issuer,
        ValidateAudience = true,
        ValidAudience = jwtSettings.Audience,
        ClockSkew = TimeSpan.Zero
    };
});

// Repository registrations
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

// Service registrations
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IJwtService, JwtService>();
builder.Services.AddScoped<IReportService, ReportService>();
builder.Services.AddScoped<IBrandService, BrandService>();
builder.Services.AddScoped<ISubCategoryService, SubCategoryService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IPropertyTypeService, PropertyTypeService>();
builder.Services.AddScoped<IPropertyValueService, PropertyValueService>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<ICartService, CartService>();

// API Services
builder.Services.AddHttpClient<IRestService, RestService>();
builder.Services.AddScoped<ICommentApiService, CommentApiService>();
builder.Services.AddScoped<IAuthApiService, AuthApiService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Otomatik migration - veritabanını otomatik güncelle
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<MarketWorldDbContext>();
    context.Database.Migrate();
    
    // Admin kullanıcısını oluştur
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    await AdminSeedData.SeedAdminUserAsync(userManager, roleManager);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Session middleware'i kullan
app.UseSession();

// JWT Middleware'ini ekle
app.UseMiddleware<JwtMiddleware>();

// Authentication ve Authorization ayarları
app.UseAuthentication();
app.UseAuthorization();

// Area route'unu en üste alıyoruz
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "products",
    pattern: "{subCategoryName}",
    defaults: new { controller = "Product", action = "ListBySubCategory" }
);

app.Run();
