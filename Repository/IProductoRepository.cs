using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    // Repositorio de Productos
    public interface IProductoRepository
    {

        List<Producto> ObtenerTodos();
        void GuardarTodos(List<Producto> productos);
    }
}
