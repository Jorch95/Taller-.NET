namespace Aseguradora.Repositorios;
using Aseguradora.Aplicacion.Entidades;
using Microsoft.EntityFrameworkCore;

public class AseguradoraContext : DbContext{
    #nullable disable
    public DbSet<Titular> Titulares { get; set; }
    public DbSet<Vehiculo> Vehiculos { get; set; }
    public DbSet<Poliza> Polizas {get;set;}
    public DbSet<Siniestro> Siniestros {get;set;}
    public DbSet<Tercero> Terceros {get;set;}
    #nullable restore
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.EnableSensitiveDataLogging(true);
        optionsBuilder.UseSqlite("data source=Aseguradora.sqlite");
    }
}