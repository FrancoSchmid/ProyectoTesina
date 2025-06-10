using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryTesina
{
    public interface Ipersona
    {
        private DateTime nacimiento;
        private String domicilio;
        private Bool sexo;

        public DateTime Nacimiento
        {
            get { return nacimiento; }
            set { nacimiento = value; }
        }

        public String Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public Bool Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
    }
}
