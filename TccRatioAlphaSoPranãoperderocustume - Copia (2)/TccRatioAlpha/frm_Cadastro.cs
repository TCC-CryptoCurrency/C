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
    public partial class frm_Cadastro : Form
    {
        public frm_Cadastro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!(txt_CPF.Text == "" || txt_Data.Text == "" || txt_Email.Text == "" || txt_Nome.Text == "" || txt_Senha.Text == "")) 
            {
                Cadastro a = new Cadastro();
                a.setCpf(Convert.ToString(txt_CPF.Text));
                a.setData(DateTime.Parse(txt_Data.Text));
                a.setEmail(Convert.ToString(txt_Email.Text));
                a.setNome(Convert.ToString(txt_Nome.Text));
                a.setSenha(Convert.ToString(txt_Senha.Text));

                UsuarioDAO b = new UsuarioDAO();
                b.criarUsu(a);
            }
        }
    }
}
