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
    public partial class ucCadastroCliente : UserControl
    {
        public ucCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (!(txt_Cpf.Text == "" || txt_Email.Text == "" || txt_nasc.Text == "" || txt_Nome.Text == "" || txt_Senha.Text == "" ))
            {
                UsuarioDAO b = new UsuarioDAO();
                Cadastro a = new Cadastro();
                a.setNome(txt_Nome.Text);
                a.setEmail(txt_Email.Text);
                a.setCpf(txt_Cpf.Text);
                a.setSenha(txt_Senha.Text);
                a.setData(DateTime.Parse(txt_nasc.Text));


                b.criarUsu(a);

                txt_Cpf.Clear();
                txt_Email.Clear();
                txt_nasc.Clear();
                txt_Nome.Clear();
                txt_Senha.Clear();

                txt_Nome.Focus();
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos disponiveis", "error");
            }
        }
    }
}
