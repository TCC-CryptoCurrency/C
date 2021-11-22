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
    public partial class ucConsultaTransação : UserControl
    {
        CadastroTrans CadastroTrans = new CadastroTrans();
        TransacaoDAO TransacaoDAO = new TransacaoDAO();
        MoedaDAO MoedaDAO = new MoedaDAO();
        UsuarioDAO UsuarioDAO = new UsuarioDAO();
        public ucConsultaTransação()
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
            int count = TransacaoDAO.quantidade();
            int aa = 0;

            for (int i = 0; i <= count; i++)
            {
                if (!(TransacaoDAO.listarUsu(i) == null))
                {
                    CadastroTrans a = TransacaoDAO.listarUsu(i);

                    grdUsu.Rows.Add();

                    grdUsu.Rows[aa].Cells[0].Value = a.getId();
                    grdUsu.Rows[aa].Cells[1].Value = a.getValor();
                    grdUsu.Rows[aa].Cells[2].Value = a.getdataTrans();
                    grdUsu.Rows[aa].Cells[3].Value = a.getOrigem();
                    grdUsu.Rows[aa].Cells[4].Value = a.getMoeda();
                    grdUsu.Rows[aa].Cells[5].Value = a.getDestino();

                    aa++;
                }
            }
            listarMoedas();
            listarOrigem();
            listarDestino();
        }
        public void listarMoedas()
        {
            // Pega os Id da tabela do banco de dados
            int count = MoedaDAO.quantidade();

            for (int i = 0; i <= count; i++)
            {
                if (MoedaDAO.listarMoeda(i) != null)
                {
                    CadastroMoeda A = MoedaDAO.listarMoeda(i);

                    cbMoeda.Items.Add(A.getNome());
                }
            }
        }
        public void listarDestino()
        {
            // Pega os Id da tabela do banco de dados
            int count = UsuarioDAO.quantidade();

            for (int i = 0; i <= count; i++)
            {
                if (UsuarioDAO.listarUsu(i) != null)
                {
                    Cadastro A = UsuarioDAO.listarUsu(i);

                    cbDestino.Items.Add(A.getNome());
                }
            }
        }
        public void listarOrigem()
        {
            // Pega os Id da tabela do banco de dados
            int count = UsuarioDAO.quantidade();

            for (int i = 0; i <= count; i++)
            {
                if (UsuarioDAO.listarUsu(i) != null)
                {
                    Cadastro A = UsuarioDAO.listarUsu(i);

                    cbOrigem.Items.Add(A.getNome());
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CadastroTrans a = new CadastroTrans();
            a.setId(int.Parse(txtId.Text));
            a.setdataTrans(DateTime.Parse(txtData.Text));
            a.setDestino(cbDestino.SelectedItem.ToString());
            a.setMoeda(cbMoeda.SelectedItem.ToString());
            a.setOrigem(cbOrigem.SelectedItem.ToString());
            a.setValor(Double.Parse(txtValord.Text));

            TransacaoDAO.atualizarTrans(a);

            listarTable();

            txtId.Clear();
            txtData.Clear();
            txtValord.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            TransacaoDAO.excluirTrans(int.Parse(txtId.Text));

            listarTable();

            txtId.Clear();
            txtData.Clear();
            txtValord.Clear();
        }

        private void grdUsu_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int aa = grdUsu.CurrentRow.Index;
            txtId.Text = grdUsu.Rows[aa].Cells[0].Value.ToString();
            txtValord.Text = grdUsu.Rows[aa].Cells[1].Value.ToString();
            txtData.Text = grdUsu.Rows[aa].Cells[2].Value.ToString();
            cbOrigem.SelectedItem = grdUsu.Rows[aa].Cells[3].Value.ToString();
            cbMoeda.SelectedItem = grdUsu.Rows[aa].Cells[4].Value.ToString();
            cbOrigem.SelectedItem = grdUsu.Rows[aa].Cells[5].Value.ToString();
        }
    }
}
