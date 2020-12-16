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
    public partial class Circulo : Form
    {
        public Circulo()
        {
            InitializeComponent();
        }

        private void btncalcirculo_Click(object sender, EventArgs e)
        {
            Area a = new Area();
            decimal resultado = a.Circulo(numradio.Value);
            lblarea.Text = resultado + "";
            
        }
        private void btncerrarcirculo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
