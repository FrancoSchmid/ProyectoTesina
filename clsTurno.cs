using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTesina
{
    public class clsTurno
    {
        private String nombre;
        private DateTime fechahora;
        private String cancha;

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fechahora { get => fechahora; set => fechahora = value; }
        public string Cancha { get => cancha; set => cancha = value; }

        public string CodigoTurno
        {
            get
            {
                return $"{Nombre}_{Fechahora:yyyyMMdd_HHmm}";
            }
        }

        public clsTurno Agregar(TextBox nombre, DateTime nuevoTurno, String cancha) 
        {
            clsTurno nuevo = new clsTurno();

            nuevo.Nombre = nombre.Text;
            nuevo.Fechahora = nuevoTurno;
            nuevo.Cancha = cancha;

            return nuevo;
        }
    }
}
