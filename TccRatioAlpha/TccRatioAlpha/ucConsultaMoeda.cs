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
    public partial class ucConsultaMoeda : UserControl
    {
        MoedaDAO consultaDao = new MoedaDAO();
        public ucConsultaMoeda()
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
                if (!(consultaDao.listarMoeda(i) == null))
                {
                    CadastroMoeda a = consultaDao.listarMoeda(i);

                    grdUsu.Rows.Add();

                    grdUsu.Rows[aa].Cells[0].Value = a.getId();
                    grdUsu.Rows[aa].Cells[1].Value = a.getNome();
                    grdUsu.Rows[aa].Cells[2].Value = a.getValor();
                    grdUsu.Rows[aa].Cells[3].Value = a.getAtt();


                    aa++;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CadastroMoeda a = new CadastroMoeda();
            a.setId(int.Parse(txtId.Text));
            a.setNome(txtNome.Text);
            a.setValor(Double.Parse(txtValor.Text));
            a.setAttt(DateTime.Parse(txtAtt.Text));

            consultaDao.atualizarMoeda(a);

            listarTable();

            txtId.Clear();
            txtNome.Clear();
            txtAtt.Clear();
            txtValor.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            consultaDao.excluirMoeda(int.Parse(txtId.Text));

            listarTable();

            txtId.Clear();
            txtNome.Clear();
            txtAtt.Clear();
            txtValor.Clear();
        }
    }
}
