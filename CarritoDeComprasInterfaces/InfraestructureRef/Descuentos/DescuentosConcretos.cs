using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarritoDeComprasInterfaces.Interfaces;

namespace CarritoDeComprasInterfaces.InfraestructureRef.Descuentos
{
    // L - Principio de Sustitución de Liskov:
    // Cada clase derivada debe ser sustituible por su clase base.
    // En este caso, todas las clases de descuento implementan la interfaz IDescuento
    // y pueden ser utilizadas de manera intercambiable.
    public class SinDescuento : IDescuento
    {
        public decimal AplicarDescuento(decimal total)
        {
            return total;
        }
    }
    public class DescuentoDeEstudiante : IDescuento
    {
        public decimal AplicarDescuento(decimal total)
        {
            return total * 0.9m; // 10% de descuento
        }
    }
    public class DescuentoDeVeterano : IDescuento
    {
        public decimal AplicarDescuento(decimal total)
        {
            return total * 0.85m; // 15% de descuento
        }
    }
    public class DescuentoDeEmpleado : IDescuento
    {
        public decimal AplicarDescuento(decimal total)
        {
            return total * 0.8m; // 20% de descuento
        }
    }
    public class DescuentoDeClienteFrecuente : IDescuento
    {
        public decimal AplicarDescuento(decimal total)
        {
            return total * 0.95m; // 5% de descuento
        }
    }
}
