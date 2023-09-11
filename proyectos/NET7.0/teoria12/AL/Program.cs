using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using AL.Data;
using AL.Aplicacion.UseCases;
using AL.Aplicacion.Interfaces;
using AL.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddTransient<AgregarClienteUseCase>();
builder.Services.AddTransient<ListarClientesUseCase>();
builder.Services.AddTransient<EliminarClienteUseCase>();
builder.Services.AddTransient<ModificarClienteUseCase>();
builder.Services.AddTransient<ObtenerClienteUseCase>();
builder.Services.AddScoped<IRepositorioCliente, RepositorioClienteMock>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
