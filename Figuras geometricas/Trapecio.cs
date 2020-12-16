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
    public partial class Trapecio : Form
    {
        public Trapecio()
        {
            InitializeComponent();
        }
        private void btncalarea_Click(object sender, EventArgs e)
        {
            Area a = new Area();
            decimal resultado = a.Trapcecio(numbasemayor.Value, numbasemenor.Value, numaltura.Value);
            lblareatrapecio.Text = resultado + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
