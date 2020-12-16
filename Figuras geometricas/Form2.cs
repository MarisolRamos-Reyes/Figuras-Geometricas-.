using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_geometricas
{
    public partial class btnformhexagono : Form
    {
        public btnformhexagono()
        {
            InitializeComponent();
        }

        private void btnformcuadrado_Click(object sender, EventArgs e)
        {
            Form formulario = new Cuadrado();
            formulario.Show();
        }
        private void btnrectangulo_Click(object sender, EventArgs e)
        {
            Form formulario = new Rectangulo();
            formulario.Show();
        }
        private void btnformtriangulo_Click(object sender, EventArgs e)
        {
            Form formulario = new Triangulo();
            formulario.Show();
        }
        private void btnformcirculo_Click(object sender, EventArgs e)
        {
            Form formulario = new Circulo();
            formulario.Show();
        }
        private void btnformromboide_Click(object sender, EventArgs e)
        {
            Form formulario = new Romboide();
            formulario.Show();
        }
        private void btnformtrapecio_Click(object sender, EventArgs e)
        {
            Form formulario = new Trapecio();
            formulario.Show();
        }
        private void btnformpentagono_Click(object sender, EventArgs e)
        {
            Form formulario = new Pentagono();
            formulario.Show();
        }
        private void btnformhexago_Click(object sender, EventArgs e)
        {
            Form formulario = new Hexagono();
            formulario.Show();
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
