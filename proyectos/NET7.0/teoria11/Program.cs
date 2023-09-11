using teoria11;
using Microsoft.Extensions.DependencyInjection;

var servicios = new ServiceCollection();
servicios.AddSingleton<ILogger, LoggerNum>();
servicios.AddTransient<IServicioX, ServicioX>();

var proveedor = servicios.BuildServiceProvider();

var servicioX = proveedor.GetService<IServicioX>();
servicioX?.Ejecutar();

var logger = proveedor.GetService<ILogger>();
logger?.Log("Fin del programa");

/* var servicioX = proveerdor.GetServicioX();
servicioX.Ejecutar();

var logger = proveerdor.GetLogger();
logger.Log("Fin del programa"); */