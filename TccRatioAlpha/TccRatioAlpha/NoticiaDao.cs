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
    class NoticiaDao
    {
        SqlConnection conn = classeConexão.obterConexao();
        public void criarNoticia(CadastroNoticia cad)
        {
            //conn = new SqlConnection(connString);

            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    // Insere na tbl Cliente
                    string queryString = "INSERT INTO Noticia (Titulo,DescNot) VALUES (@1,@2)";
                    SqlCommand cmd = new SqlCommand(queryString, conn);
                    cmd.Parameters.Add("@1", SqlDbType.NVarChar, 90).Value = cad.getTitulo();
                    cmd.Parameters.Add("@2", SqlDbType.NVarChar, 90).Value = cad.getDescricao();

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

        public void associarTag(CadastroTags tag)
        {
            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    // Decobre o id da ultima noticia
                    SqlCommand cmd = new SqlCommand("select Max(idNoticia) from Noticia", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    int[] aux = new int[2];
                    aux[0] = Convert.ToInt32(reader[0]);

                    cmd = new SqlCommand("select idTags WHERE Tags WHERE NomeTag=@1", conn);
                    cmd.Parameters.AddWithValue("@1", tag.getNome());
                    reader = cmd.ExecuteReader();
                    aux[1] = Convert.ToInt32(reader[0]);

                    cmd = new SqlCommand("INSERT INTO DetalheTagNoticia (idNoticia,idTags) VALUES (@1,@2)", conn);
                    cmd.Parameters.Add("@1", SqlDbType.NVarChar, 90).Value = aux[0];
                    cmd.Parameters.Add("@2", SqlDbType.NVarChar, 90).Value = aux[1];

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

        public void atualizarNoticia(CadastroNoticia a)
        {
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Noticia SET Titulo=@1, DescNot=@2 where idNoticia=@0", conn);
                cmd.Parameters.AddWithValue("@1", a.getTitulo());
                cmd.Parameters.AddWithValue("@2", a.getDescricao());
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

        public void excluirNoticia(int id)
        {
            CadastroNoticia cliente = new CadastroNoticia();

            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd1 = new SqlCommand("DELETE FROM Noticia WHERE idNoticia=@1", conn);
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

        public CadastroNoticia listarNoticia(int id)
        {
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("select * from Noticia where idNoticia = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    CadastroNoticia a = new CadastroNoticia();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {

                        a.setId(id);

                        a.setId(int.Parse(reader[0].ToString()));
                        a.setTitulo(reader[1].ToString());
                        a.setDescricao(reader[2].ToString());
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

            if (conn.State == ConnectionState.Open)
            {
                string queryString = "select Max(idNoticia) from Noticia";
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
