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
    public partial class Rectangulo : Form
    {
        public Rectangulo()
        {
            InitializeComponent();
        }
        private void btncalarearetangulo_Click(object sender, EventArgs e)
        {
            Area a = new Area();
            decimal resultado = a.Rectangulo(numbaserec.Value, numalturarec.Value);
            lblarearectangulo.Text = resultado + "";
        }
        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
