namespace Almacen.Aplicacion;
public class ListarProductoUseCase{
    private readonly IRepositorioProducto _repo;
    public ListarProductoUseCase(IRepositorioProducto repo){
        _repo = repo;
    }
    public List<Producto> Ejecutar(){
        return _repo.ListarProductos();
    }

}