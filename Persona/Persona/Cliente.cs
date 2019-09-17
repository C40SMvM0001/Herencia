using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    public class Cliente : Persona
    {
        public string Nit;
        public string Procedencia;

        public void MostrarCliente(string Ci, string Nombre, string Apellido, string Nit, string Procedencia) {
            this.Ci = Ci ;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Nit =Nit;
            this.Procedencia = Procedencia;
        }
        
    }
}
