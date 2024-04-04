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
        Bitmap bmpFirma;
        public frmFirma()
        {
            InitializeComponent();
        }

        private void frmFirma_Load(object sender, EventArgs e)
        {
            bmpFirma = new Bitmap(pictureBox1.Width, pictureBox1.Height);
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

        private void frmFirma_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Text = "Presiona izquierdo";

                /*using (Graphics miFirma = this.CreateGraphics())
                {
                    //Pen pen = new Pen(Color.Black, 5);

                    miFirma.FillEllipse(Brushes.Black, e.X, e.Y, 7, 7);
                }*/
            }
            if(e.Button == MouseButtons.Right)
            {
                this.Text = "Presiona derecho";
            }
        }

        private void frmFirma_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Text = "Suelta izquierdo";
            }
            if (e.Button == MouseButtons.Right)
            {
                this.Text = "Suelta derecho";
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                bmpFirma.Save("firma.jpg");
                MessageBox.Show("Firma grabada, gracias");

                pictureBox1.Invalidate();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics miFirma = pictureBox1.CreateGraphics())
                {
                    //Pen pen = new Pen(Color.Black, 5);

                    miFirma.FillEllipse(Brushes.Black, e.X, e.Y, 7, 7);
                }
                using (Graphics miFirma = Graphics.FromImage(bmpFirma))
                {
                    //Pen pen = new Pen(Color.Black, 5);

                    miFirma.FillEllipse(Brushes.Black, e.X, e.Y, 7, 7);
                }
            }
        }
    }
}
