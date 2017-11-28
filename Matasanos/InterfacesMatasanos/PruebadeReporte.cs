using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesMatasanos
{
    public partial class PruebadeReporte : Form
    {
        public PruebadeReporte()
        {
            InitializeComponent();
        }

        private void PruebadeReporte_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
