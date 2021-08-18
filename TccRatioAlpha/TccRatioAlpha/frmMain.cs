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
            Panel p = this.Parent as Panel;
            var cadP = new ucMain();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(cadP);
        }

        private void btnMP_Click(object sender, EventArgs e)
        {
            Panel p = this.Parent as Panel;
            var cadP = new ucModeloCadastro();
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
    }
}
