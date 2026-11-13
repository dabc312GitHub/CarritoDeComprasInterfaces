using CarritoDeComprasInterfaces.Interfaces;
using CarritoDeComprasInterfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeComprasInterfaces.Services
{

    // D - Inversión de Dependencias:
    // CajaRegistradora depende de abstracciones (IOutput y IDescuento)
    // en lugar de implementaciones concretas.
    internal class CajaRegistradora
    {
        private readonly IOutput _output;
        private readonly IDescuento _descuento;

        // O - Principio de abierto/cerrado:
        // CajaRegistradora está abierta para extensión
        // (puede aceptar diferentes implementaciones de IOutput e IDescuento)
        public CajaRegistradora(IOutput output, IDescuento descuento)
        {
            _output = output;
            _descuento = descuento;
        }

        public void ProcesarCompra(CarritoDeCompras carrito)
        {
            decimal total = carrito.CalcularTotal();
            decimal totalConDescuento = _descuento.AplicarDescuento(total);
            _output.Mostrar($"Total: {total:C}");
            _output.Mostrar($"Total con descuento: {totalConDescuento:C}");
        }
    }
}
