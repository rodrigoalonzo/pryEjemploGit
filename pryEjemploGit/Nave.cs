using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEjemploGit
{
    internal class Nave
    {
        public int vida = 100;

        int disparo = 1;

        public string nombre;

        public PictureBox imagenNave;

        public void CrearJugador()
        {
            nombre = "GenioProgrammer";
            imagenNave = new PictureBox();
            imagenNave.ImageLocation = "URL";
            //imagenNave.ImageLocation =
            imagenNave.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void CrearEnemigo()
        {
            nombre = "Nave mala 1";
            imagenNave = new PictureBox();
        }
    }
}
