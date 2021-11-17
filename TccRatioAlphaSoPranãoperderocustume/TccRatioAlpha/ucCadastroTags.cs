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
    public partial class ucCadastroTags : UserControl
    {
        TagsDao b = new TagsDao();
        CadastroNoticia a = new CadastroNoticia();
        NoticiaDao c = new NoticiaDao();
        CadastroTags d = new CadastroTags();
        public ucCadastroTags()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtDesc.Text != "") {
                d.setNome(txtNome.Text);
                d.setDesc(txtDesc.Text);
                b.criarTag(d);

                MessageBox.Show("Registro inserido com sucesso!");

                txtNome.Clear();
                txtDesc.Clear();
            }
        }
    }
}
