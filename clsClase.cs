using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTesina
{
    public class clsClase: clsTurno
    {
        private string categoria;
        private int idprofe;
        private List<int> alumnos;

        public string Categoria { get => categoria; set => categoria = value; }
        public int Idprofe { get => idprofe; set => idprofe = value; }
        public List<int> Alumnos { get => alumnos; set => alumnos = value; }

        public void Agregar(TextBox Categoria, TextBox DNIprofe, ComboBox Horario, TextBox Idcancha,
                    TextBox Alumno1, TextBox Alumno2, TextBox Alumno3, TextBox Alumno4)
        {
            if (string.IsNullOrWhiteSpace(Categoria.Text) ||
                string.IsNullOrWhiteSpace(DNIprofe.Text) ||
                Horario.SelectedItem == null ||
                string.IsNullOrWhiteSpace(Idcancha.Text))
            {
                MessageBox.Show("Por favor complete todos los campos obligatorios.");
                return;
            }

            // Lista temporal para almacenar los alumnos ingresados
            List<int> alumnosIngresados = new List<int>();

            // Recolectar los alumnos manualmente escritos (máximo 4, ignorando vacíos)
            TextBox[] cajasAlumnos = { Alumno1, Alumno2, Alumno3, Alumno4 };

            foreach (TextBox txt in cajasAlumnos)
            {
                if (!string.IsNullOrWhiteSpace(txt.Text))
                {
                    if (int.TryParse(txt.Text, out int idAlumno))
                    {
                        alumnosIngresados.Add(idAlumno);
                    }
                    else
                    {
                        MessageBox.Show($"El valor '{txt.Text}' no es un número válido para un alumno.");
                        return;
                    }
                }
            }

            if (alumnosIngresados.Count < 2)
            {
                MessageBox.Show("Debe ingresar al menos dos alumnos.");
                return;
            }

            try
            {
                clsClase nuevaClase = new clsClase
                { 
                    Categoria = Categoria.Text,
                    Idprofe = Convert.ToInt32(DNIprofe.Text),
                    Alumnos = alumnosIngresados

                };

                MessageBox.Show("Clase agregada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la clase: " + ex.Message);
            }
        }

    }
}
