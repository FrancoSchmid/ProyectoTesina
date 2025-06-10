using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryTesina
{
    public class clsPersona: Ipersona
    {
        private String nombre;
        private Int16 numero;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public Int16 Numero
        {
            get { return numero; }
            set { numero = value; }
        }
    }
}
