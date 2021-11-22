﻿using System;
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
    public partial class ucConsultaCliente : UserControl
    {
        UsuarioDAO consultaDao = new UsuarioDAO();
        public ucConsultaCliente()
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
                if (!(consultaDao.listarUsu(i) == null))
                {
                    Cadastro a = consultaDao.listarUsu(i);

                    grdUsu.Rows.Add();

                    grdUsu.Rows[aa].Cells[0].Value = a.getId();
                    grdUsu.Rows[aa].Cells[1].Value = a.getNome();
                    grdUsu.Rows[aa].Cells[2].Value = a.getEmail();
                    grdUsu.Rows[aa].Cells[3].Value = a.getSenha();
                    grdUsu.Rows[aa].Cells[4].Value = a.getCpf();
                    grdUsu.Rows[aa].Cells[5].Value = a.getData();

                    aa++;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cadastro a = new Cadastro();
            a.setId(int.Parse(txtId.Text));
            a.setNome(txtNome.Text);
            a.setEmail(txtEmail.Text);
            a.setCpf(txtCPF.Text);
            a.setSenha(txtSenha.Text);
            a.setData(DateTime.Parse(txtNasc.Text));

            consultaDao.atualizarUsu(a);

            listarTable();

            txtId.Clear();
            txtEmail.Clear();
            txtCPF.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtNasc.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            consultaDao.excluirUsu(int.Parse(txtId.Text));

            listarTable();

            txtId.Clear();
            txtEmail.Clear();
            txtCPF.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtNasc.Clear();
        }

        private void grdUsu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int aa = grdUsu.CurrentRow.Index;
            txtId.Text = grdUsu.Rows[aa].Cells[0].Value.ToString();
            txtNome.Text = grdUsu.Rows[aa].Cells[1].Value.ToString();
            txtEmail.Text = grdUsu.Rows[aa].Cells[2].Value.ToString();
            txtSenha.Text = grdUsu.Rows[aa].Cells[3].Value.ToString();
            txtCPF.Text = grdUsu.Rows[aa].Cells[4].Value.ToString();
            txtNasc.Text = grdUsu.Rows[aa].Cells[5].Value.ToString();
        }
    }
}
