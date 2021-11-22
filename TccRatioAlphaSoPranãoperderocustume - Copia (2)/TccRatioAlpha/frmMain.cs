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
            Panel p = this.Parent as Panel;
            var cadP = new ucMain();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(cadP);
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel p = this.Parent as Panel;
            var cadP = new ucCadastroCliente();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(cadP);
        }

        private void moedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel p = this.Parent as Panel;
            var cadP = new ucCadastroMoeda();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(cadP);
        }

        private void noticiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel p = this.Parent as Panel;
            var cadP = new ucCadastroNoticia();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(cadP);
        }

        private void transaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel p = this.Parent as Panel;
            var cadP = new ucCadastroTransacao();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(cadP);
        }

        private void tagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel p = this.Parent as Panel;
            var cadP = new ucCadastroTags();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(cadP);
        }

        private void graficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel p = this.Parent as Panel;
            var cadP = new ucGrafico();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(cadP);
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Panel p = this.Parent as Panel;
            var cadP = new ucConsultaCliente();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(cadP);
        }

        private void moedaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Panel p = this.Parent as Panel;
            var cadP = new ucConsultaMoeda();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(cadP);
        }

        private void noticiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Panel p = this.Parent as Panel;
            var cadP = new ucCadastroNoticia();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(cadP);
        }

        private void transaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Panel p = this.Parent as Panel;
            var cadP = new ucConsultaTransação();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(cadP);
        }

        private void tagsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Panel p = this.Parent as Panel;
            var cadP = new ucConsultaTags();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(cadP);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel p = this.Parent as Panel;
            var cadP = new ucMain();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(cadP);
        }
    }
}
