using CarritoDeComprasInterfaces.Interfaces;
using CarritoDeComprasInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeComprasInterfaces.Repositorio
{
    internal class MemoriaProductoRepository: IProductoRepository
    {
        private readonly List<Producto> _db = new List<Producto>()
        {
            new Producto { Id = 1, Nombre = "Pollo roaster", Precio = 10.0m },
            new Producto { Id = 2, Nombre = "Mouse bluetooth", Precio = 20.0m },
            new Producto { Id = 3, Nombre = "Monitor 24 pulgadas", Precio = 30.0m }
        };

        public Producto ObtenerDatoPorId(int id)
        {
            return _db.FirstOrDefault(p => p.Id == id);
        }
        public IEnumerable<Producto> ObtenerTodos()
        {
            return _db;
        }
    }
}
