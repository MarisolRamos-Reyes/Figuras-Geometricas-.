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
    public partial class Cuadrado : Form
    {
        public Cuadrado()
        {
            InitializeComponent();
        }

        private void btncalcuadrado_Click(object sender, EventArgs e)
        {
            Area a = new Area();
            decimal resultado = a.Cuadrado(numlado.Value);
            lblareacuadrado.Text = resultado + "";
        }

        private void btncerrarcuadrado_Click(object sender, EventArgs e)
        {

            this.Close();
        
        }
    }
}
