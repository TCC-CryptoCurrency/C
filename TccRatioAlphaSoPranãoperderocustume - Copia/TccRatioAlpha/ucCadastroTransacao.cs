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
    public partial class ucCadastroTransacao : UserControl
    {
        CadastroTrans a = new CadastroTrans();
        TransacaoDAO transacao = new TransacaoDAO();
        MoedaDAO moedas = new MoedaDAO();
        UsuarioDAO usuario = new UsuarioDAO();
        public ucCadastroTransacao()
        {
            InitializeComponent();
        }
        public void listarMoedas()
        {
            // Pega os Id da tabela do banco de dados
            int count = moedas.quantidade();

            for (int i = 0; i <= count; i++)
            {
                if (moedas.listarMoeda(i) != null)
                {
                    CadastroMoeda A = moedas.listarMoeda(i);

                    cbTipo.Items.Add(A.getNome());
                }
            }
        }
        public void listarDestino()
        {
            // Pega os Id da tabela do banco de dados
            int count = usuario.quantidade();

            for (int i = 0; i <= count; i++)
            {
                if (usuario.listarUsu(i) != null)
                {
                    Cadastro A = usuario.listarUsu(i);

                    cbDestino.Items.Add(A.getNome());
                }
            }
        }
        public void listarOrigem()
        {
            // Pega os Id da tabela do banco de dados
            int count = usuario.quantidade();

            for (int i = 0; i <= count; i++)
            {
                if (usuario.listarUsu(i) != null)
                {
                    Cadastro A = usuario.listarUsu(i);

                    cbOrigem.Items.Add(A.getNome());
                }
            }
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if(txtValor.Text != "" && txtDataTrans.Text != "" && cbDestino.SelectedItem.ToString() != "" && cbTipo.SelectedItem.ToString() != "" && cbDestino.SelectedItem.ToString() != cbOrigem.SelectedItem.ToString())
            {
                a.setValor(Double.Parse(txtValor.Text));
                a.setdataTrans(DateTime.Parse(txtDataTrans.Text));
                if (cbOrigem.SelectedItem.ToString() != "")
                    a.setOrigem(cbOrigem.SelectedItem.ToString());
                a.setDestino(cbDestino.SelectedItem.ToString());
                a.setMoeda(cbTipo.SelectedItem.ToString());

                transacao.criarTrans(a);
            }
            else
            {
                MessageBox.Show("erro: ","Por favor refaça");
            }
        }
    }
}
