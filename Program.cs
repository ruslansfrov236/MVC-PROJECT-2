using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task_16.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("SqlServer");
builder.Services.AddDbContext<Task16DbContext>(options =>
{
    options.UseSqlServer(connectionString);
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapAreaControllerRoute(
    name: "areas",
    areaName: "admin",
    pattern: "details/{id}",
    defaults: new { controller = "Tables", action = "Details" }
    );
app.MapAreaControllerRoute(
    name: "areas",
    areaName: "admin",
    pattern:"table",
    defaults: new {controller= "Tables" , action="Index" }
    );

app.MapAreaControllerRoute(
    name: "areas",
    areaName: "admin",
    pattern: "update/{id}",
    defaults: new { controller = "Forms", action = "UpdateForm"  }
);
app.MapAreaControllerRoute(
    name: "areas",
    areaName: "admin",
    pattern: "delete/{id}",
    defaults: new { controller = "Forms", action = "DeleteForm" }
);
app.MapAreaControllerRoute(
    name: "areas",
    areaName: "admin",
    pattern: "form",
    defaults: new { controller = "Forms", action = "CreateForm" }
);

app.MapAreaControllerRoute(
    name: "areas",
    areaName: "admin",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}"
);
app.Run();
