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
    public partial class frmJuego : Form
    {
        public frmJuego()
        {
            InitializeComponent();
        }

        Nave objNaveJugador = new Nave();
        Nave objNaveEnemigo = new Nave();

        private void frmJuego_Load(object sender, EventArgs e)
        {
            objNaveJugador.CrearJugador();

            objNaveJugador.imagenNave.Location = new Point(250,250);
            Controls.Add(objNaveJugador.imagenNave);

            objNaveEnemigo.CrearEnemigo();

            objNaveEnemigo.imagenNave.Location = new Point(250, 150);
            Controls.Add(objNaveEnemigo.imagenNave);

            //MessageBox.Show("Jugador: " + objNaveJugador.nombre);
            //MessageBox.Show("Enemigo: " + objNaveEnemigo.nombre);

            this.Refresh();
        }
    }
}
