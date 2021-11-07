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
    public partial class ucCadastroNoticia : UserControl
    {
        TagsDao b = new TagsDao();
        CadastroNoticia a = new CadastroNoticia();
        NoticiaDao c = new NoticiaDao();
        CadastroTags d = new CadastroTags();

        public ucCadastroNoticia()
        {
            InitializeComponent();
            clTags.Items.Clear();
            listarTags();
        }
        public void listarTags()
        {
            // Pega os Id da tabela do banco de dados
            int count = b.quantidade();

            for (int i = 0; i <= count; i++)
            {
                if (b.listarTags(i) != null)
                {
                    CadastroTags A = b.listarTags(i);

                    clTags.Items.Add(A.getNome());
                }
            }
        }

        private void btnCad_Click(object sender, EventArgs e)
        {

            if (!(txtTitulo.Text == "" || txtDesc.Text == ""))
            {
                a.setTitulo(txtTitulo.Text);
                a.setDescricao(txtDesc.Text);
                c.criarNoticia(a);

                foreach (string a in clTags.CheckedItems)
                {
                    d.setNome(a.ToString());
                    c.associarTag(d);
                }
            }
            MessageBox.Show("Registro inserido com sucesso!");
        }
    }
}
