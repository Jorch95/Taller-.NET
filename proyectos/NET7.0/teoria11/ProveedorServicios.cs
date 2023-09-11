namespace teoria11;
class ProveedorServicios :IServicioX{
    public ILogger GetLogger() => new LoggerConsola();
    public void Ejecutar() => this.GetLogger();
}