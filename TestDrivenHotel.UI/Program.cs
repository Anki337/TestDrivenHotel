using Microsoft.EntityFrameworkCore;
using System;
using TestDrivenHotel.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Hämta ConnString från appsettings.json
var connectionString = builder.Configuration.GetConnectionString("HotelRoomsDbConnection");
// Lägg tll AppDbContext i DI-Containern.
builder.Services.AddDbContext<HotelRoomsDB>(options => options.UseSqlServer(connectionString));
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

app.Run();
