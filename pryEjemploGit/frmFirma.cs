using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEjemploGit
{
    public partial class frmFirma : Form
    {
        public frmFirma()
        {
            InitializeComponent();
        }

        private void frmFirma_Load(object sender, EventArgs e)
        {

        }

        private void frmFirma_MouseMove(object sender, MouseEventArgs e)
        {
            // this.Text = e.Location.ToString();
        }

        private void frmFirma_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Text = "Presiona el botón izquierdo";
            }
            else
            {
                this.Text = "-";
            }
        }
    }
}
