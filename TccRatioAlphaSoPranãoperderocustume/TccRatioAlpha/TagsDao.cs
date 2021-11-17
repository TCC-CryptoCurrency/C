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
    class TagsDao
    {
        SqlConnection conn = classeConexão.obterConexao();
        SqlConnection conn1 = classeConexão.obterConexao();
        public void criarTag(CadastroTags cad)
        {
            //conn = new SqlConnection(connString);
            conn = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    // Insere na tbl Cliente
                    string queryString = "INSERT INTO Tags (NomeTag,DescTag) VALUES (@1,@2)";
                    SqlCommand cmd = new SqlCommand(queryString, conn);
                    cmd.Parameters.Add("@1", SqlDbType.NVarChar, 90).Value = cad.getNome();
                    cmd.Parameters.Add("@2", SqlDbType.NVarChar, 90).Value = cad.getDesc();

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

        public void atualizarTag(CadastroTags a)
        {
            conn = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Tags SET NomeTag=@1, DescTag=@2 where idTags=@0", conn);
                cmd.Parameters.AddWithValue("@1", a.getNome());
                cmd.Parameters.AddWithValue("@2", a.getDesc());
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

        public void excluirTags(int id)
        {
            conn = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd1 = new SqlCommand("DELETE FROM Tags WHERE idTags=@1", conn);
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

        public CadastroTags listarTags(int id)
        {
            conn = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("select * from Tags where idTags = @id", conn);
                SqlDataReader reader;
                cmd.Parameters.AddWithValue("@id", id);
                reader = cmd.ExecuteReader();

                try
                {
                    CadastroTags a = new CadastroTags();
                    

                    if (reader.Read())
                    {

                        a.setId(int.Parse(reader[0].ToString()));
                        a.setNome(reader[1].ToString());
                        a.setDesc(reader[2].ToString());
                        return a;

                    }
                    else
                    {
                        return null;

                    }
                    
                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro: " + error);

                    return null;
                }
                finally
                {
                    reader.Close();
                    cmd.Dispose();
                    classeConexão.fecharConexao();
                }
            }
            else
            {
                return null;
            }

        }

       
        public int quantidade()
        {
            conn = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open)
            {
                string queryString = "select Max(idTags) from Tags";

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
