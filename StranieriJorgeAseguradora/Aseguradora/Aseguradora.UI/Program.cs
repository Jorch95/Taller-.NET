using Aseguradora.UI.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Aseguradora.Repositorios;
using Aseguradora.Aplicacion.UseCases;
using Aseguradora.Aplicacion.Interfaces;

//Para póliza.Si hay vidrio roto, no hay un tercero
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddScoped<IRepositorioTitular, RepositorioTitular>();
builder.Services.AddTransient<AgregarTitularUseCase>();
builder.Services.AddTransient<ModificarTitularUseCase>();
builder.Services.AddTransient<EliminarTitularUseCase>();
builder.Services.AddTransient<ListarTitularesUseCase>();
builder.Services.AddTransient<ObtenerTitularUseCase>();

builder.Services.AddScoped<IRepositorioVehiculo, RepositorioVehiculo>();
builder.Services.AddTransient<AgregarVehiculoUseCase>();
builder.Services.AddTransient<ModificarVehiculoUseCase>();
builder.Services.AddTransient<EliminarVehiculoUseCase>();
builder.Services.AddTransient<ListarVehiculosUseCase>();
builder.Services.AddTransient<ObtenerVehiculoUseCase>();

builder.Services.AddScoped<IRepositorioSiniestro, RepositorioSiniestro>();
builder.Services.AddTransient<AgregarSiniestroUseCase>();
builder.Services.AddTransient<ModificarSiniestroUseCase>();
builder.Services.AddTransient<EliminarSiniestroUseCase>();
builder.Services.AddTransient<ListarSiniestrosUseCase>();
builder.Services.AddTransient<ObtenerSiniestroUseCase>();

builder.Services.AddScoped<IRepositorioTercero, RepositorioTercero>();
builder.Services.AddTransient<AgregarTerceroUseCase>();
builder.Services.AddTransient<ModificarTerceroUseCase>();
builder.Services.AddTransient<EliminarTerceroUseCase>();
builder.Services.AddTransient<ListarTercerosUseCase>();
builder.Services.AddTransient<ObtenerTerceroUseCase>();

builder.Services.AddScoped<IRepositorioPoliza, RepositorioPoliza>();
builder.Services.AddTransient<AgregarPolizaUseCase>();
builder.Services.AddTransient<ModificarPolizaUseCase>();
builder.Services.AddTransient<EliminarPolizaUseCase>();
builder.Services.AddTransient<ListarPolizasUseCase>();
builder.Services.AddTransient<ObtenerPolizaUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()){
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

using (var context = new AseguradoraContext()){ //El using es para asegurar que el objeto DbContext
    context.Database.EnsureCreated();       //sea usado en una única unidad de trabajo
    var connection = context.Database.GetDbConnection();
    connection.Open();
    using (var command = connection.CreateCommand()){
        command.CommandText = "PRAGMA journal_mode=DELETE;";
        command.ExecuteNonQuery();
    }
    AseguradoraInit.Inicializar(context);    
}

app.Run();
