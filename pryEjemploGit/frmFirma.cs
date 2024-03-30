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
        bool pintar = false;
        bool borrar = false;
        bool presionado = false;

        public frmFirma()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            pintar = false;
            borrar = true;
        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            pintar = true;
            borrar = false;
        }

        private void frmFirma_MouseDown(object sender, MouseEventArgs e)
        {
            presionado = true;
        }

        private void frmFirma_MouseUp(object sender, MouseEventArgs e)
        {
            presionado = false;
        }

        private void frmFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if(pintar && presionado)
            {
                Graphics pintar = CreateGraphics();
                pintar.FillEllipse(new SolidBrush(Color.Black), e.X, e.Y, 10, 10);
                pintar.Dispose();
            }
            else if(borrar && presionado)
            {
                Graphics pintar = CreateGraphics();
                pintar.FillEllipse(new SolidBrush(Color.White), e.X, e.Y, 10, 10);
                pintar.Dispose();
            }
        }
    }
}
