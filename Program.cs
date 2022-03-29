
using blazor_example.Data;
using Microsoft.EntityFrameworkCore;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddDbContext<BlazorContext>(options => options.UseNpgsql("server=localhost;port=5432;userid=postgres;database=postgres;password=example"));

builder.Services.AddScoped<DataSource>();

var app = builder.Build();


app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");


app.Run();
