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
        SqlConnection conn2 = classeConexão.obterConexao();
        public void criarUsu(Cadastro cad)
        {
            //conn = new SqlConnection(connString);

            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    // Insere na tbl Cliente
                    string queryString = "INSERT INTO Usuario (Nome,Email,CPF,Senha,DataNasc) VALUES (@1,@2,@3,@4,@5)";
                    SqlCommand cmd = new SqlCommand(queryString, conn);
                    cmd.Parameters.Add("@1", SqlDbType.NVarChar, 90).Value = cad.getNome();
                    cmd.Parameters.Add("@2", SqlDbType.NVarChar, 90).Value = cad.getEmail();
                    cmd.Parameters.Add("@3", SqlDbType.NVarChar, 90).Value = cad.getCpf();
                    cmd.Parameters.Add("@4", SqlDbType.NVarChar, 90).Value = cad.getSenha();
                    cmd.Parameters.Add("@5", SqlDbType.NVarChar, 90).Value = cad.getData();

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
                SqlCommand cmd = new SqlCommand("UPDATE Cliente SET Nome=@1, Email=@2, Cpf=@3, Senha=@4, DataNasc=@5 where idCarteira=@0", conn);
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

        public void excluirUsu(int id)
        {
            Cadastro cliente = new Cadastro();

            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd1 = new SqlCommand("DELETE FROM Usuario WHERE idCarteira=@1", conn);
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
        public Cadastro listarUsu(int id)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("select * from Usuario where idCarteira = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    try
                    {
                        Cadastro a = new Cadastro();
                        

                        if (reader.Read())
                        {

                            a.setId(id);

                            a.setId(int.Parse(reader[0].ToString()));
                            a.setNome(reader[1].ToString());
                            a.setEmail(reader[2].ToString());
                            a.setSenha(reader[6].ToString());
                            a.setData(DateTime.Parse(reader[4].ToString()));
                            a.setCpf(reader[5].ToString());
                            return a;
                        }
                        else
                        {
                            return null;
                        }
                        reader.Close();
                        cmd.Dispose();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Erro: " + error);

                        return null;
                    }
                    finally
                    {
                        classeConexão.fecharConexao();
                    }
                }
                else
                {
                    MessageBox.Show(conn.State.ToString());
                    return null;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro: " + error);

                return null;
            }

        }

        public int quantidade()
        {

            if (conn.State == ConnectionState.Open)
            {
                string queryString = "select Max(idCarteira) from Usuario";

                SqlCommand cmd = new SqlCommand(queryString, conn);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            return Convert.ToInt32(reader[0]);
                        }
                    }
                    cmd.Dispose();
                    reader.Close();
                    return 0;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro: " + error);

                    return 0;
                }
                finally
                {
                   
                    classeConexão.fecharConexao();
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
