using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryTesina
{
    using System;

    namespace pryTesina
    {
        public class clsAlumno : clsPersona
        {
            private DateTime nacimiento;
            private string domicilio;
            private bool sexo;
            private string categoria;
            private int numeroEmergencia;
            private string fichaMedica;

            public DateTime Nacimiento
            {
                get { return nacimiento; }
                set { nacimiento = value; }
            }

            public string Domicilio
            {
                get { return domicilio; }
                set { domicilio = value; }
            }

            public bool Sexo
            {
                get { return sexo; }
                set { sexo = value; }
            }

            public string Categoria
            {
                get { return categoria; }
                set { categoria = value; }
            }

            public int NumeroEmergencia
            {
                get { return numeroEmergencia; }
                set { numeroEmergencia = value; }
            }

            public string FichaMedica
            {
                get { return fichaMedica; }
                set { fichaMedica = value; }
            }
        }
    }

}
