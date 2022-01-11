using MyLittleBluRayThequeProject.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using NetCore.AutoRegisterDi;
using MyLittleBluRayThequeProject.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TODO;Data Source=(local)"));

var app = builder.Build();

var assembliesToScan = new[]
         {
              Assembly.GetExecutingAssembly(),
              typeof(IBluRayRepository).Assembly
         };
builder.Services.RegisterAssemblyPublicNonGenericClasses(assembliesToScan)
        .AsPublicImplementedInterfaces();
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
