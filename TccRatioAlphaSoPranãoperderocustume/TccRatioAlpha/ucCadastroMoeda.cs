using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TccRatioAlpha
{
    public partial class ucCadastroMoeda : UserControl
    {
        CadastroMoeda a = new CadastroMoeda();
        MoedaDAO b = new MoedaDAO();
        public ucCadastroMoeda()
        {
            InitializeComponent();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if(txt_Nome.Text !="" && txt_Valor.Text != "")
            {
                a.setNome(txt_Nome.Text);
                string bufunfa = txt_Valor.Text;
                bufunfa = bufunfa.Replace("R$", string.Empty);
                bufunfa = bufunfa.Replace(" ", string.Empty);
                a.setValor(Double.Parse(bufunfa));

                b.criarMoeda(a);
            }
        }

        private void txt_Valor_TextChanged(object sender, EventArgs e)
        {
            string aux;
            aux = txt_Valor.Text;

            txt_Valor.Text = "R$" + aux;
        }
    }
}
