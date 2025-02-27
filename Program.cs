using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SystemIdentity.Areas.Identity.Data;
using SystemIdentity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SystemIdentityContextConnection") ?? throw new InvalidOperationException("Connection string 'SystemIdentityContextConnection' not found.");

builder.Services.AddDbContext<SystemIdentityContext>(options => options.UseSqlite(connectionString));

builder.Services.AddDefaultIdentity<SystemUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<SystemIdentityContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.MapRazorPages();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
