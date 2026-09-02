using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArchivotexto
{
    public partial class frmGrabardatos : Form
    {
        public frmGrabardatos()
        {
            InitializeComponent();
        }


        clsArchivo x = new clsArchivo();

        private void frmGrabardatos_Load(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            x.Grabar(txtGrabar.Text);
            MessageBox.Show("Datos grabados correctamente.");
        }
    }
}
