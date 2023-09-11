namespace Almacen.Aplicacion;
public interface IRepositorioProducto {
    void AgregarProducto(Producto producto);
    List<Producto> ListarProductos();
}