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
    public partial class ucConsultaNoticia : UserControl
    {
        CadastroNoticia a = new CadastroNoticia();
        TagsDao b = new TagsDao();
        NoticiaDao consultaDao = new NoticiaDao();
        CadastroTags d = new CadastroTags();
        public ucConsultaNoticia()
        {
            InitializeComponent();
            listarTable();
        }
        public void listarTable()
        {

            for (int i = 0; i < grdUsu.RowCount; i++)
            {
                grdUsu.Rows[i].DataGridView.Rows.Clear();
            }
            // Pega os Id da tabela do banco de dados
            int count = consultaDao.quantidade();
            int aa = 0;

            for (int i = 0; i <= count; i++)
            {
                if (!(consultaDao.listarNoticia(i) == null))
                {
                    CadastroNoticia a = consultaDao.listarNoticia(i);

                    grdUsu.Rows.Add();

                    grdUsu.Rows[aa].Cells[0].Value = a.getId();
                    grdUsu.Rows[aa].Cells[1].Value = a.getTitulo();
                    grdUsu.Rows[aa].Cells[2].Value = a.getDescricao();
                    grdUsu.Rows[aa].Cells[3].Value = a.getData();

                    aa++;
                }
            }
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
        private void btnEditar_Click(object sender, EventArgs e)
        {
            CadastroNoticia a = new CadastroNoticia();
            a.setId(int.Parse(txtId.Text));
            a.setTitulo(txtTitulo.Text);
            a.setDescricao(txtDesc.Text);
            foreach (string h in clTags.CheckedItems)
            {
                d.setNome(h.ToString());

                consultaDao.associarTag(d,a);
            }

            consultaDao.atualizarNoticia(a);

            listarTable();

            txtId.Clear();
            txtDesc.Clear();
            txtTitulo.Clear();
            txtAtt.Clear();
            foreach (int i in clTags.CheckedIndices)
            {
                clTags.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void grdUsu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int aa = grdUsu.CurrentRow.Index;
            txtId.Text = grdUsu.Rows[aa].Cells[0].Value.ToString();
            txtTitulo.Text = grdUsu.Rows[aa].Cells[1].Value.ToString();
            txtDesc.Text = grdUsu.Rows[aa].Cells[2].Value.ToString();
            txtAtt.Text = grdUsu.Rows[aa].Cells[3].Value.ToString();
            int count = consultaDao.quantidadeTag(int.Parse(txtId.Text));
            for (int i = 0; i <= count; i++) 
            {
                if (consultaDao.checkTag(int.Parse(txtId.Text), i))
                {
                    b.listarTags(i);
                    clTags.SetItemChecked((i-1),true);
                }
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                consultaDao.excluirNoticia(int.Parse(txtId.Text));
                listarTable();
                txtId.Clear();
                txtTitulo.Clear();
                txtDesc.Clear();
                txtAtt.Clear();
            }
            else
            {
                MessageBox.Show("erro: ","por gentileza selecione alguma noticia");
            }
        }
    }
}
