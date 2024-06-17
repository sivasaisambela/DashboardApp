

using DashboardAPI.Identity;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient<IRoleStore<ApplicationRole>, ApplicationRoleStore>();

builder.Services.AddTransient<UserManager<ApplicationUser>, ApplicationUserManager>();

builder.Services.AddTransient<SignInManager<ApplicationUser>, ApplicationSignInManager>();

builder.Services.AddTransient<RoleManager<ApplicationRole>, ApplicationRoleManager>();

builder.Services.AddTransient<IUserStore<ApplicationUser>, ApplicationUserStore>();

//builder.Services.AddTransient<IUserService, UserService>();



builder.Services.AddIdentity<ApplicationUser, ApplicationRole>()

    .AddEntityFrameworkStores<ApplicationDbContext>()

    .AddUserStore<ApplicationUserStore>()

    .AddUserManager<ApplicationUserManager>()

    .AddRoleManager<ApplicationRoleManager>()

    .AddSignInManager<ApplicationSignInManager>()

    .AddRoleStore<ApplicationRoleStore>()

    .AddDefaultTokenProviders();



builder.Services.AddScoped<ApplicationRoleStore>();

builder.Services.AddScoped<ApplicationUserStore>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
