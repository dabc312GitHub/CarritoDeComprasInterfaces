using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoDeComprasInterfaces.Interfaces
{
    // I - Segregación de interfaces:
    // Se ha creado una interfaz separada para el descuento,
    // lo que permite que las clases que implementen esta interfaz solo se preocupen
    // por la lógica de descuento y no tengan que implementar métodos innecesarios.
    internal interface IDescuento
    {
        decimal AplicarDescuento(decimal total);
    }
}
