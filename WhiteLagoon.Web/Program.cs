using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Stripe;
using System.Globalization;
using WhiteLagoon.Application.Common.Interfaces;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;
using WhiteLagoon.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(option =>
{
    option.AccessDeniedPath = "/Account/AccessDenied";
    option.LoginPath = "/Account/Login";
});

builder.Services.Configure<IdentityOptions>(option =>
{
    option.Password.RequiredLength = 6;
});


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

StripeConfiguration.ApiKey = builder.Configuration.GetSection("Stripe:SecretKey").Get<string>();
//Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
//Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;

//Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-GB");
//Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-GB");


//Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
//Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");

CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

//CultureInfo.DefaultThreadCurrentCulture = CultureInfo.GetCultureInfo("vi-VN");
//CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("vi-VN");

//CultureInfo.DefaultThreadCurrentCulture = CultureInfo.GetCultureInfo("en-US");
//CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("en-US");

//CultureInfo.DefaultThreadCurrentCulture = CultureInfo.GetCultureInfo("en-GB");
//CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("en-GB");

//CultureInfo.GetCultureInfo("en-US");
//yyyy - MM - dd

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
