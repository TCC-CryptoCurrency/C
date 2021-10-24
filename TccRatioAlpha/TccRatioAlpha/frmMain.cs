using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TccRatioAlpha
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        { 
            panelPrincipal.Controls.Clear();
        }

        private void btnMP_Click(object sender, EventArgs e)
        {
            Panel p = this.Parent as Panel;
            var cadP = new ucCadastroCliente();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(cadP);
        }

        private void btnMC_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel p = this.Parent as Panel;
            var cadP = new ucCadastroMoeda();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(cadP);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel p = this.Parent as Panel;
            var cadP = new ucConsultaCliente();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(cadP);
        }
    }
}
