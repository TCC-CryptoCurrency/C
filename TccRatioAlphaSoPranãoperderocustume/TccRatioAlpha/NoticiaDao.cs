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
        SqlConnection conn;
        SqlConnection conn1;
        public void criarNoticia(CadastroNoticia cad)
        {
            //conn = new SqlConnection(connString);
            conn = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    // Insere na tbl Cliente
                    string queryString = "INSERT INTO Noticia (Titulo,DescNot,DataNot,LinkNot) VALUES (@1,@2,@3,@4)";
                    SqlCommand cmd = new SqlCommand(queryString, conn);
                    cmd.Parameters.Add("@1", SqlDbType.NVarChar, 90).Value = cad.getTitulo();
                    cmd.Parameters.Add("@2", SqlDbType.NVarChar, 90).Value = cad.getDescricao();
                    cmd.Parameters.Add("@3", SqlDbType.Date, 90).Value = DateTime.Now;
                    cmd.Parameters.Add("@4", SqlDbType.NVarChar, 90).Value = cad.getLink();

                    cmd.ExecuteScalar();
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

        public void associarTag(CadastroTags tag, CadastroNoticia not)
        {
            conn = classeConexão.obterConexao();
            conn1 = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open && conn1.State == ConnectionState.Open)
            {
                try
                {
                    int[] aux = new int[2];

                    // Decobre o id da ultima noticia
                    SqlCommand cmd = new SqlCommand("select Max(idNoticia) from Noticia", conn);
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                        aux[0] = Convert.ToInt32(reader[0]);
                    conn.Dispose();

                    conn = classeConexão.obterConexao();
                    SqlCommand cmd1 = new SqlCommand("select idTags FROM Tags WHERE NomeTag=@1", conn);
                    cmd1.Parameters.AddWithValue("@1", tag.getNome());
                    SqlDataReader reader1 = cmd1.ExecuteReader();
                    if(reader1.Read())
                        aux[1] = Convert.ToInt32(reader1[0]);
                    conn.Dispose();

                    conn = classeConexão.obterConexao();
                    SqlCommand cmd0 = new SqlCommand("select * from DetalheTagNoticia where idNoticia = @1 and idTags = @2", conn1);
                    cmd0.Parameters.AddWithValue("@1", not.getId());
                    cmd0.Parameters.AddWithValue("@2", aux[1]);
                    SqlDataReader reader0;
                    reader0 = cmd0.ExecuteReader();
                    if (reader0.Read())
                    {
                        conn = classeConexão.obterConexao();
                        cmd0 = new SqlCommand("DELETE from DetalheTagNoticia where idNoticia = @1 and idTags = @2", conn);
                        cmd0.Parameters.AddWithValue("@1", not.getId());
                        cmd0.Parameters.AddWithValue("@2", aux[1]);
                        int i = cmd0.ExecuteNonQuery();
                    }
                    conn.Dispose();
                    conn1.Dispose();

                    conn = classeConexão.obterConexao();
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO DetalheTagNoticia (idNoticia,idTags) VALUES (@1,@2)", conn);
                    if(not.getId() == 0)
                        cmd2.Parameters.Add("@1", SqlDbType.NVarChar, 90).Value = aux[0];
                    else
                        cmd2.Parameters.Add("@1", SqlDbType.NVarChar, 90).Value = not.getId();
                    cmd2.Parameters.Add("@2", SqlDbType.NVarChar, 90).Value = aux[1];

                    cmd2.ExecuteScalar();

                    reader.Close();
                    reader1.Close();
                    conn.Dispose();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro: " + error);
                
                }
                finally
                {

                    
                }
            }
        }

        public void atualizarNoticia(CadastroNoticia a)
        {
            conn = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Noticia SET Titulo=@1, DescNot=@2, DataNot=@3, LinkNot where idNoticia=@0", conn);
                cmd.Parameters.AddWithValue("@1", a.getTitulo());
                cmd.Parameters.AddWithValue("@2", a.getDescricao());
                cmd.Parameters.AddWithValue("@3", DateTime.Now);
                cmd.Parameters.AddWithValue("@3", a.getLink());
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
            conn = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM DetalheTagNoticia WHERE idNoticia=@1", conn);
                SqlCommand cmd1 = new SqlCommand("DELETE FROM Noticia WHERE idNoticia=@1", conn);
                cmd.Parameters.AddWithValue("@1", id);
                cmd1.Parameters.AddWithValue("@1", id);


                try
                {
                    int i = cmd.ExecuteNonQuery();
                    int j = cmd1.ExecuteNonQuery();
                    if (j > 0 && i>0)
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
            conn = classeConexão.obterConexao();
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
                        a.setData(DateTime.Parse(reader[3].ToString()));
                        a.setLink(reader[4].ToString());
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
            conn = classeConexão.obterConexao();
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

        public int quantidadeTag(int id) 
        {
            conn = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("select max(idTags) from DetalheTagNoticia where idNoticia = @id",conn);
                cmd.Parameters.AddWithValue("@id", id);

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
        public bool checkTag(int idn,int idt)
        {
            conn = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("select * from DetalheTagNoticia where idNoticia = @1 and idTags = @2", conn);
                cmd.Parameters.AddWithValue("@1", idn);
                cmd.Parameters.AddWithValue("@2", idt);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                    }

                    return false;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro: " + error);

                    return false;
                }
                finally
                {
                    classeConexão.fecharConexao();
                }
            }
            else
            {
                return false;
            }
        }
    }
}
