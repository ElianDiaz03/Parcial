using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Entidades
{
    class Usuario
    {
        private string nombre;
        private double contra;

        public Usuario()
        {
        }

        public Usuario(string nombre, double contra)
        {
            this.Nombre = nombre;
            this.Contra = contra;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Contra { get => contra; set => contra = value; }

    }
}      

