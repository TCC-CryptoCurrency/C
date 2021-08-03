using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TccRatioAlpha
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            Frm_Splash Frm_Splash = new Frm_Splash();
            Frm_Splash.Show();
            Frm_Splash.Refresh();
            Thread.Sleep(1000);
            Frm_Splash.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.setUsuario(Convert.ToString(txt_Usuario.Text));
            Login.setSenha(Convert.ToString(txt_Senha.Text));
            Login.Verifica();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            frm_Cadastro a = new frm_Cadastro();
            this.Hide();
            a.ShowDialog();
            this.Show();

        }
    }
}
