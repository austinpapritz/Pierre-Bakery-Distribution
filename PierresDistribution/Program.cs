var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Populate app with default data
Vendor vendor1 = new("Billy's Bakery");
Vendor vendor2 = new("Crazy Croissants");
Vendor vendor3 = new("Bread-O-Rama");

app.Run();
