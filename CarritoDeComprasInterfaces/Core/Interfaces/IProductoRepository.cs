using CarritoDeComprasInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarritoDeComprasInterfaces.Interfaces
{
    internal interface IProductoRepository
    {
        Producto ObtenerDatoPorId(int id);
        IEnumerable<Producto> ObtenerTodos();
    }
}
