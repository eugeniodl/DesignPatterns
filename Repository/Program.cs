using Repository;


// Ruta del archivo para almacenar productos
string archivoProductos = "productos.txt";

// Crear una instancia del repositorio de productos
// utilizando el archivo
IProductoRepository productoRepository
    = new ProductoRepositoryArchivo(archivoProductos);

// Crear una instancia del gestor de productos 
// utilizando el repositorio
GestorProductos gestorProductos
    = new GestorProductos(productoRepository);

// Agregar algunos productos de ejemplo
gestorProductos.AgregarProducto(
    new Producto { Nombre = "Leche", Precio = 32m });
gestorProductos.AgregarProducto(
    new Producto { Nombre = "Pan", Precio = 24m });

// Mostrar todos los productos
Console.WriteLine( "Todos los productos:");
foreach (var producto in gestorProductos.ObtenerTodosLosProductos())
    Console.WriteLine( $"Nombre: {producto.Nombre}," +
        $"Precio: {producto.Precio}");

