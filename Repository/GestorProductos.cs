using Repository;

public class GestorProductos
{
    private IProductoRepository _repository;

    public GestorProductos(IProductoRepository repository)
    {
        _repository = repository;
    }

    public List<Producto> ObtenerTodosLosProductos()
    {
        return _repository.ObtenerTodos();
    }

    public void AgregarProducto(Producto producto)
    {
        List<Producto> productos = _repository.ObtenerTodos();
        productos.Add(producto);
        _repository.GuardarTodos(productos);
    }
}