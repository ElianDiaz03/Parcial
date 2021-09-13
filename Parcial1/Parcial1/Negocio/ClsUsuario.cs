using Parcial1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Negocio
{
    class ClsUsuario
    {
        string persona = "Elian";
        Double Contraseña = 123;
        public int C = 1;

        Usuario Cons = new Usuario();
        private double contraseña;

        public string Acceso(Usuario Cons)
        {
            if (Cons.Nombre == persona && Cons.Contra== contraseña)

            {
                C = 1;
                return "Has iniciado sesión Correctamente";
            }
            else
                C = 2;
            return "usuario y/o contraseña incorrecta";
        }
}   }   
