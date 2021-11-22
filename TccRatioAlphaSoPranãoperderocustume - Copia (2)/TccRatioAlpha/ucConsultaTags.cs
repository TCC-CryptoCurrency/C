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
    public partial class ucConsultaTags : UserControl
    {
        TagsDao consultaDao = new TagsDao();
        CadastroTags a = new CadastroTags();
        public ucConsultaTags()
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
                if (!(consultaDao.listarTags(i) == null))
                {
                    CadastroTags a = consultaDao.listarTags(i);

                    grdUsu.Rows.Add();

                    grdUsu.Rows[aa].Cells[0].Value = a.getId();
                    grdUsu.Rows[aa].Cells[1].Value = a.getNome();
                    grdUsu.Rows[aa].Cells[2].Value = a.getDesc();

                    aa++;
                }
            }
        }
       

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CadastroTags a = new CadastroTags();
            a.setId(int.Parse(txtId.Text));
            a.setNome(txtNome.Text);
            a.setDesc(txtDesc.Text);

            consultaDao.atualizarTag(a);

            listarTable();

            txtId.Clear();
            txtNome.Clear();
            txtDesc.Clear();
        }

        private void grdUsu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int aa = grdUsu.CurrentRow.Index;
            txtId.Text = grdUsu.Rows[aa].Cells[0].Value.ToString();
            txtNome.Text = grdUsu.Rows[aa].Cells[1].Value.ToString();
            txtDesc.Text = grdUsu.Rows[aa].Cells[2].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            consultaDao.excluirTags(int.Parse(txtId.Text));

            listarTable();
            txtId.Clear();
            txtNome.Clear();
            txtDesc.Clear();
        }
    }
}
