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
    public partial class Romboide : Form
    {
        public Romboide()
        {
            InitializeComponent();
        }
        private void btncalcularromboide_Click(object sender, EventArgs e)
        {
            Area a = new Area();
            decimal resultado = a.Romboide(numbaserom.Value,numalturarom.Value);
            lblarear.Text = resultado + "";
        }

        private void btncerrarrom_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}