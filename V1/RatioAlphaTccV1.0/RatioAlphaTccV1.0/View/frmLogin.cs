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

namespace RatioAlphaTccV1._0
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Splash frmSplashScreen = new Splash();
            frmSplashScreen.Show();
            frmSplashScreen.Refresh();
            Thread.Sleep(1000);
            frmSplashScreen.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void txtSenha_MouseClick(object sender, MouseEventArgs e)
        {
            txtSenha.Text = "";
            txtSenha.ForeColor = Color.FromArgb(231, 236, 239);
            txtSenha.UseSystemPasswordChar = true;
        }

        private void txtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsuario.Text = "";
            txtUsuario.ForeColor = Color.FromArgb(231, 236, 239);
       }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.ForeColor != Color.Gray)
            {
                if ((txtSenha.UseSystemPasswordChar))
                {
                    txtSenha.UseSystemPasswordChar = false;
                    btnMostrar.Text = "Esconder";
                }
                else
                {
                    txtSenha.UseSystemPasswordChar = true;
                    btnMostrar.Text = "Mostrar";
                }
            }
        }

        private void txtUsuario_MouseLeave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtSenha_MouseLeave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = Color.Gray;
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
