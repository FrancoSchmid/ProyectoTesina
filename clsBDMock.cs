using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryTesina
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace pryTesina
    {
        public class clsBDMock
        {
            private static List<clsTurno> turnos = new List<clsTurno>();

            public void GuardarTurno(clsTurno turno)
            {
                var existente = turnos.FirstOrDefault(t => t.CodigoTurno == turno.CodigoTurno);
                if (existente != null)
                {
                    turnos.Remove(existente);
                }
                turnos.Add(turno);
            }

            public List<clsTurno> ObtenerTurnosPorCanchaYFecha(string cancha, DateTime fecha)
            {
                return turnos.Where(t => t.Nombre == cancha && t.Fechahora.Date == fecha.Date).ToList();
            }

            public clsTurno ObtenerTurnoPorCanchaYFechaHora(string cancha, DateTime fechaHora)
            {
                return turnos.FirstOrDefault(t => t.Nombre == cancha && t.Fechahora == fechaHora);
            }
        }
    }

}
