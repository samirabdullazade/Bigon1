using Bigon1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var cString = builder.Configuration.GetConnectionString("cString");
builder.Services.AddDbContext<DataContext>(cfg =>
{
    cfg.UseSqlServer(cString);
});



var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");

app.Run();
