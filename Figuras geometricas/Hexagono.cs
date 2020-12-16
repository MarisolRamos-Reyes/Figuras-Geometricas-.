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
    public partial class Hexagono : Form
    {
        public Hexagono()
        {
            InitializeComponent();
        }

        private void btncalarea_Click(object sender, EventArgs e)
        {
            Area a = new Area();
            decimal resultado = a.Pentagono(numbasemenor.Value, numaltura.Value);
            lblareapentagono.Text = resultado + "";
        }

        private void btncerrarhexagono_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
