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
    class MoedaDAO
    {
        SqlConnection conn;
        SqlConnection conn1;
        public void criarMoeda(CadastroMoeda cad)
        {
            //conn = new SqlConnection(connString);
            conn = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    // Insere na tbl Cliente
                    string queryString = "INSERT INTO Moeda (NomeMoeda,ValorMoeda,DataAtualizacao) VALUES (@1,@2,@3)";
                    SqlCommand cmd = new SqlCommand(queryString, conn);
                    cmd.Parameters.Add("@1", SqlDbType.NVarChar, 90).Value = cad.getNome();
                    cmd.Parameters.Add("@2", SqlDbType.Money, 90).Value = cad.getValor();
                    cmd.Parameters.Add("@3", SqlDbType.Date, 90).Value = DateTime.Now;

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

        public void atualizarMoeda(CadastroMoeda a)
        {
            conn = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open)
            {
                historicoMoeda(a);
                SqlCommand cmd = new SqlCommand("UPDATE Moeda SET NomeMoeda=@1, ValorMoeda=@2, DataAtualizacao=@3 where idMoeda=@0", conn);
                cmd.Parameters.AddWithValue("@1", a.getNome());
                cmd.Parameters.AddWithValue("@2", a.getValor());
                cmd.Parameters.AddWithValue("@3", DateTime.Now);
                cmd.Parameters.AddWithValue("@0", a.getId());

                cmd.CommandType = CommandType.Text;
                //conn.Open();
                try
                {
                    historicoMoeda(a);
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
                    classeConexão.fecharConexao();
                }
            }
        }

        public void excluirMoeda(int id)
        {
            conn = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd1 = new SqlCommand("DELETE FROM Moeda WHERE idMoeda=@1", conn);
                cmd1.Parameters.AddWithValue("@1", id);


                try
                {
                    excluirHistorico(id);
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
                    classeConexão.fecharConexao();
                }
            }
        }
        public CadastroMoeda listarMoeda(int id)
        {
            conn1 = classeConexão.obterConexao();
            if (conn1.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("select * from Moeda where idMoeda = @id", conn1);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    CadastroMoeda a = new CadastroMoeda();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        a.setId(int.Parse(reader[0].ToString()));
                        a.setNome(reader[1].ToString());
                        a.setValor(Double.Parse(reader[2].ToString()));
                        a.setAttt(DateTime.Parse(reader[3].ToString()));
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
                MessageBox.Show("Erro: " + conn1.State.ToString());
                return null;
            }

        }

        public int quantidade()
        {
            conn = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open)
            {
                string queryString = "select Max(idMoeda) from Moeda";

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
                    conn.Dispose();
                    classeConexão.fecharConexao();
                }
            }
            else
            {
                return 0;
            }
        }
        public void historicoMoeda(CadastroMoeda a) 
        {
            conn1 = classeConexão.obterConexao();
            if (conn1.State == ConnectionState.Open)
            {
                try
                {
                    // Insere na tbl Cliente
                    string queryString = "INSERT INTO HistoricoMoeda (DataRegistro,ValorData,idMoeda) VALUES (@1,@2,@3)";
                    SqlCommand cmd = new SqlCommand(queryString, conn1);
                    DateTime b = DateTime.Now;
                    string c = b.ToString("d");
                    cmd.Parameters.Add("@1", SqlDbType.Date, 90).Value = c;
                    cmd.Parameters.Add("@2", SqlDbType.Money, 90).Value = a.getValor();
                    cmd.Parameters.Add("@3", SqlDbType.Int, 90).Value = a.getId();

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

        public CadastroMoeda listarHistoricoMoeda(int id, DateTime A)
        {
            conn1 = classeConexão.obterConexao();
            if (conn1.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("select * from HistoricoMoeda where idMoeda = @id and DataRegistro = @a", conn1);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@a", A);

                try
                {
                    CadastroMoeda a = new CadastroMoeda();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {

                        a.setId(id);

                        a.setIdHistorico(int.Parse(reader[0].ToString()));
                        a.setAttt(DateTime.Parse(reader[1].ToString()));
                        a.setValor(Double.Parse(reader[2].ToString()));
                        a.setId(int.Parse(reader[3].ToString()));
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
                MessageBox.Show("Erro: " + conn1.State.ToString());
                return null;
            }

        }

        public DateTime getOldest(int id) 
        {
            DateTime A = DateTime.Now;
            conn1 = classeConexão.obterConexao();
            if (conn1.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("select MIN(DataRegistro) from HistoricoMoeda where idMoeda = @id", conn1);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        return DateTime.Parse(reader[0].ToString());
                    }
                    else
                    {
                        return A;
                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro: " + error);

                    return A;
                }
                finally
                {
                    classeConexão.fecharConexao();

                }
            }
            else
            {
                MessageBox.Show("Erro: " + conn1.State.ToString());
                return A;
            }
        }

        public void excluirHistorico(int id)
        {
            conn = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd1 = new SqlCommand("DELETE FROM HistoricoMoeda WHERE idMoeda=@1", conn);
                cmd1.Parameters.AddWithValue("@1", id);


                try
                {
                    int j = cmd1.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    classeConexão.fecharConexao();
                }
            }
        }

        public int getIds(CadastroMoeda a)
        {
            conn = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd1;
                SqlDataReader reader;
                cmd1 = new SqlCommand("SELECT idMoeda FROM Moeda WHERE NomeMoeda=@1", conn);
                cmd1.Parameters.Add("@1", SqlDbType.NVarChar, 90).Value = a.getNome();
                reader = cmd1.ExecuteReader();
                if (reader.Read())
                    return (int.Parse(reader[0].ToString()));
                cmd1.Dispose();
                reader.Close();
                return 0;
            }
            else
            {
                return 0;
            }
        }
    }
}
