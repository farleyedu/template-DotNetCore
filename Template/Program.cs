using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Template.Data.Context;

var builder = WebApplication.CreateBuilder(args);
//string connString = builder.Configuration.GetConnectionString("TemplateDB");

builder.Services.AddDbContext<TemplateContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("TemplateDB"));

});
// Add services to the container.

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}





//builder.Services.AddDbContext<TemplateContext>(opt =>
//{
//    opt.UseSqlServer(builder.Configuration.GetConnectionString("TemplateDB"));
//});

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
