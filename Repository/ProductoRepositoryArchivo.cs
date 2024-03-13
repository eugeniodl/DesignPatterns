using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductoRepositoryArchivo : IProductoRepository
    {
        private string _nombreArchivo;

        public ProductoRepositoryArchivo(string nombreArchivo)
        {
            _nombreArchivo = nombreArchivo;
        }
        public void GuardarTodos(List<Producto> productos)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_nombreArchivo))
                {
                    foreach (Producto producto in productos)
                    {
                        sw.WriteLine($"{producto.Nombre},{producto.Precio}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error al escribir en el archivo: {e.Message}");
            }
        }

        public List<Producto> ObtenerTodos()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                using (StreamReader sr = new StreamReader(_nombreArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        Producto producto = new Producto
                        {
                            Nombre = datos[0],
                            Precio = Convert.ToDecimal(datos[1])
                        };
                        productos.Add(producto);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error al leer el archivo: {e.Message}");
            }
            return productos;
        }
    }
}
