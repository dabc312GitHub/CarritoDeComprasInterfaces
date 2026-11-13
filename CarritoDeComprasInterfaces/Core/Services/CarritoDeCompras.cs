using CarritoDeComprasInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeComprasInterfaces.Services
{
    internal class CarritoDeCompras
    {
        private readonly List<ItemCarrito> _items = new List<ItemCarrito>();
        public void AgregarProducto(Producto producto, int cantidad)
        {
            var itemExistente = _items.FirstOrDefault(i => i.Producto.Id == producto.Id);
            if (itemExistente != null)
            {
                itemExistente.Cantidad += cantidad;
            }
            else
            {
                _items.Add(new ItemCarrito { Producto = producto, Cantidad = cantidad });
            }
        }
        public IReadOnlyList<ItemCarrito> ObtenerItems()
        {
            return _items.AsReadOnly();
        }
        public decimal CalcularTotal()
        {
            return _items.Sum(i => i.Subtotal);
        }
    }
}
