using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeComprasInterfaces.Models
{
    // S - Principio de responsabilidad única:
    // La clase Producto tiene una única responsabilidad,
    // que es representar un producto con sus propiedades (Id, Nombre y Precio).
    // No tiene métodos adicionales que mezclen responsabilidades.
    internal class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }
}
