using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Entidades
{
    class Venta
    {
        //prod=Producto
        private double id_prod;
        private string Nombre_prod;
        private string descr_prod;
        private double Precio_prod;
        private int cantidad_prod;

        public double Id_prod { get => id_prod; set => id_prod = value; }
        public string Nombre_prod1 { get => Nombre_prod; set => Nombre_prod = value; }
        public string Descr_prod { get => descr_prod; set => descr_prod = value; }
        public double Precio_prod1 { get => Precio_prod; set => Precio_prod = value; }
        public int Cantidad_prod { get => cantidad_prod; set => cantidad_prod = value; }

        public Venta(double id_prod, string nombre_prod, string descr_prod, double precio_prod, int cantidad_prod)
        {
            this.Id_prod = id_prod;
            Nombre_prod1 = nombre_prod;
            this.Descr_prod = descr_prod;
            Precio_prod1 = precio_prod;
            this.Cantidad_prod = cantidad_prod;
        }
        public Venta()
        {

        }

    }
}
