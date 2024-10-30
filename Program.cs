using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebChordCore.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("HopAmChuan");
builder.Services.AddDbContext<HopAmChuanContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddSession();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllerRoute(
		name: "default",
		pattern: "{controller=Home}/{action=Index}/{id?}");

	endpoints.MapControllerRoute(
	name: "BaiViet",
	pattern: "hop-am/{metatitle}.{id?}",
	defaults: new { controller = "BaiViet", action = "ChiTiet" });

	endpoints.MapControllerRoute(
		name: "TimKiem",
		pattern: "hop-am/tim-kiem-hop-am",
		defaults: new { controller = "BaiViet", action = "TimKiem" }
	);
	endpoints.MapControllerRoute(
		name: "Tags",
		pattern: "Tags/{key}",
		defaults: new { controller = "BaiViet", action = "Tag" }
	);
});

app.Run();
