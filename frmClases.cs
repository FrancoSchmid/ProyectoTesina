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
            turnoActual = new clsTurno
            {
                Nombre = turnoActual.Nombre, // viene del constructor
                Fechahora = turnoActual.Fechahora,       // viene del constructor
                Tipo = rdbClase.Checked ? "Clase" : "Partido"
            };

            if (rdbClase.Checked)
            {
                turnoActual.Categoria = cmbCategoria.SelectedItem?.ToString();
                turnoActual.Profesor = cmbProfesor.SelectedItem?.ToString();

                turnoActual.Alumnos = new List<string>();
                foreach (DataGridViewRow fila in dgvListaDeTurnos.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        for (int i = 2; i <= 5; i++) // Columnas Alumno1 a Alumno4
                        {
                            string nombre = fila.Cells[i].Value?.ToString();
                            if (!string.IsNullOrWhiteSpace(nombre))
                                turnoActual.Alumnos.Add(nombre);
                        }
                    }
                }
            }
            else // Partido
            {
                turnoActual.Cliente = new clsCliente
                {
                    DNI = int.TryParse(txtDocumento.Text, out int doc) ? doc : 0,
                    Nombre = txtNombre.Text.Trim(),
                    Telefono = int.TryParse(txtTelefono.Text, out int tel) ? tel : 0
                };
            }
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

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            int documento;
            if (!int.TryParse(txtDocumento.Text, out documento))
            {
                MessageBox.Show("Ingresá un documento válido.");
                return;
            }

            clsCliente cliente = bd.BuscarClientePorDocumento(documento);

            if (cliente != null)
            {
                txtNombre.Text = cliente.Nombre;
                txtTelefono.Text = cliente.Telefono.ToString();
                MessageBox.Show("Cliente encontrado.");
            }
            else
            {
                DialogResult r = MessageBox.Show("Cliente no encontrado. ¿Deseás agregarlo?", "Nuevo Cliente", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    cliente = new clsCliente
                    {
                        DNI = documento,
                        Nombre = txtNombre.Text,
                        Telefono = int.TryParse(txtTelefono.Text, out int tel) ? tel : 0
                    };

                    bd.AgregarCliente(cliente);
                    MessageBox.Show("Cliente agregado.");
                }
            }
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            int documento;
            if (!int.TryParse(txtAlumno.Text, out documento))
            {
                MessageBox.Show("Ingresá un documento válido de alumno.");
                return;
            }

            clsAlumno alumno = bd.BuscarAlumnoPorDocumento(documento);

            if (alumno != null)
            {
                MessageBox.Show($"Alumno encontrado: {alumno.Nombre}");
            }
            else
            {
                DialogResult r = MessageBox.Show("Alumno no encontrado. ¿Deseás agregarlo?", "Nuevo Alumno", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    alumno = new clsAlumno
                    {
                        Documento = documento,
                        Nombre = "Alumno Nuevo",
                        Numero = 0,
                        // Podés agregar más datos si los tenés
                    };

                    bd.AgregarAlumno(alumno);
                    MessageBox.Show("Alumno agregado.");
                }
            }
        }
    }
}
