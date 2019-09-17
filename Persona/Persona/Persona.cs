using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    public class Persona
    {
        protected string ci;
        protected string apellido;
        protected string nombre;

        protected string Ci
        {
            get
            {
                return ci;
            }

            set
            {
                ci = value;
            }
        }

        protected string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        protected string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
    }
}
