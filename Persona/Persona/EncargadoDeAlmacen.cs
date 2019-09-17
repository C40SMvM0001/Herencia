using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    public class EncargadoDeAlmacen : Persona
    {        
        public string CodEnc;
        public string Direccion;

        public void MostrarEncargado(string Ci, string Nombre, string Apellido, string CodEnc, string Direccion)
        {
            this.Ci = Ci;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.CodEnc = CodEnc;
            this.Direccion = Direccion;
        }

    }
}
