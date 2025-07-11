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
    public partial class frmTurnos : Form
    {

        private readonly clsBDMock bd = new clsBDMock(); // simulador de base de datos

        public frmTurnos()
        {
            InitializeComponent();
        }

    }
}
