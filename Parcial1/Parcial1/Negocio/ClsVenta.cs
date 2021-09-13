using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Negocio
{
    class ClsVenta
    {
        public string Cobro()
        {
            double total = vent.Precio * vent.Cantidad;

            if (vent.Precio > 50)

            {
                double descuento = total - (total * 0.20);
                Console.WriteLine("aplica al 20% de descuento su total es de " + descuento);
            }
            else
            {
                Console.WriteLine("no aplica descuento su total es" + total);
            }

            return "";
        }
    }
}
