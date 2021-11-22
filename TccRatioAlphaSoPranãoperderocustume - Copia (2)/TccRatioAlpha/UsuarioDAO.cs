using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TccRatioAlpha
{
    class UsuarioDAO
    {
        SqlConnection conn = classeConexão.obterConexao();
        SqlConnection conn1 = classeConexão.obterConexao();
        public void criarUsu(Cadastro cad)
        {
            //conn = new SqlConnection(connString);

            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    // Insere na tbl Cliente
                    string queryString = "INSERT INTO Usuario (Nome,Email,CPF,Senha,DataNasc,ChaveTemp,DataChave) VALUES (@1,@2,@3,@4,@5,@6,@7)";
                    SqlCommand cmd = new SqlCommand(queryString, conn);
                    cmd.Parameters.Add("@1", SqlDbType.NVarChar, 40).Value = cad.getNome();
                    cmd.Parameters.Add("@2", SqlDbType.NVarChar, 24).Value = cad.getEmail();
                    cmd.Parameters.Add("@3", SqlDbType.NVarChar, 15).Value = cad.getCpf();
                    cmd.Parameters.Add("@4", SqlDbType.NVarChar, 16).Value = cad.getSenha();
                    cmd.Parameters.Add("@5", SqlDbType.NVarChar, 16).Value = cad.getData();
                    cmd.Parameters.Add("@6", SqlDbType.NVarChar, 16).Value = "A0c0d0";
                    cmd.Parameters.Add("@7", SqlDbType.NVarChar, 16).Value = DateTime.Now.ToString("dd.MM.yyyy");

                    cmd.ExecuteScalar();

                    MessageBox.Show("Registro inserido com sucesso!");
                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro: " + error);
                }
                finally
                {
                    classeConexão.fecharConexao();
                }
            }
        }
        public void atualizarUsu(Cadastro a)
        {
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Cliente SET Nome=@1, Email=@2, Cpf=@3, Senha=@4, DataNasc=@5 where IdCarteira=@0", conn);
                cmd.Parameters.AddWithValue("@1", a.getNome());
                cmd.Parameters.AddWithValue("@2", a.getEmail());
                cmd.Parameters.AddWithValue("@3", a.getCpf());
                cmd.Parameters.AddWithValue("@4", a.getSenha());
                cmd.Parameters.AddWithValue("@0", a.getId());

                cmd.CommandType = CommandType.Text;
                //conn.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();

                    if (i > 0)
                        MessageBox.Show("Registro atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public void excluirCli(int id)
        {
            Cadastro cliente = new Cadastro();

            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd1 = new SqlCommand("DELETE FROM Usuario WHERE IdCarteira=@1", conn);
                cmd1.Parameters.AddWithValue("@1", id);


                try
                {
                    int j = cmd1.ExecuteNonQuery();
                    if (j > 0)
                        MessageBox.Show("Registro excluído com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
