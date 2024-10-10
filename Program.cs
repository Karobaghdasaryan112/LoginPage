using LoginAndRegistrationPage.Data;
using LoginAndRegistrationPage.Repositories.inplimentation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder();

builder.Services.AddControllersWithViews();

string ?ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(ConnectionString));
builder.Services.AddScoped<UserReadRepository>();
builder.Services.AddScoped<UserWriteRepository>();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "login",
    pattern: "Login",
    defaults: new { controller = "Shared", action = "Login" });

app.Map("/", () => Results.Redirect("Shared/Login"));
app.Run();