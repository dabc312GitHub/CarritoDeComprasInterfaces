using CarritoDeComprasInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarritoDeComprasInterfaces.InfraestructureRef;
using CarritoDeComprasInterfaces.InfraestructureRef.Descuentos;
using CarritoDeComprasInterfaces.Services;
using CarritoDeComprasInterfaces.VisualizacionConsola;
using CarritoDeComprasInterfaces.Repositorio;

namespace CarritoDeComprasInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOutput verEnConsola = new ConsolaOutput();
            IProductoRepository repository = new MemoriaProductoRepository();

            IDescuento dsctoEstudiante= new DescuentoDeEstudiante(); // Puedes cambiar esto a otra estrategia de descuento si lo deseas
            IDescuento dsctoVeterano = new DescuentoDeVeterano(); // Puedes cambiar esto a otra estrategia de descuento si lo deseas

            var carrito = new CarritoDeCompras();
            var cajaRegistradora = new CajaRegistradora(verEnConsola, dsctoEstudiante); // Puedes cambiar esto a otra estrategia de descuento si lo deseas

            verEnConsola.Mostrar("Tienda de Productos Anthony");

            var p1 = repository.ObtenerDatoPorId(1);
            var p2 = repository.ObtenerDatoPorId(2);
            var p3 = repository.ObtenerDatoPorId(3);

            if (p1 != null) carrito.AgregarProducto(p1, 1);
            if (p2 != null) carrito.AgregarProducto(p2, 2);
            if (p3 != null) carrito.AgregarProducto(p3, 3);

            cajaRegistradora.ProcesarCompra(carrito);

            verEnConsola.Mostrar("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
