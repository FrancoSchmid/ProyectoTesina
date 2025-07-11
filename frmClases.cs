using pryTesina.pryTesina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTesina
{
    public partial class frmTurnosClases : Form
    {

        private readonly clsBDMock bd = new clsBDMock(); // simulador

        private clsTurno turnoActual;

        private void CrearTurnoDesdeControles()
        {
            // Ejemplo básico, adaptalo según tus controles y modelo clsTurno

            // Supongamos que recibiste cancha y fecha/hora por parámetro o control
            string cancha = /* si tenés un control o variable que lo indique */;
            DateTime fechaHora = /* fecha y hora seleccionada o pasada */;

            turnoActual = new clsTurno
            {
                Nombre = cancha,
                Fechahora = fechaHora,
                // Asignar más campos si clsTurno los tiene, como clientes, alumnos, etc.
            };

            // Si hay más datos, agregalos acá, por ejemplo:
            // turnoActual.Cliente = ...
            // turnoActual.Alumnos = ...
        }

        public frmTurnosClases()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CrearTurnoDesdeControles(); // Crear el turno con datos actualizados

                if (turnoActual == null)
                {
                    MessageBox.Show("No se pudo crear el turno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bd.GuardarTurno(turnoActual);

                MessageBox.Show("Turno guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el turno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
