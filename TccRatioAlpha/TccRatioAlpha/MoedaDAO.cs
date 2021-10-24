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
        SqlConnection conn = classeConexão.obterConexao();
        public void criarMoeda(CadastroMoeda cad)
        {
            //conn = new SqlConnection(connString);

            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    // Insere na tbl Cliente
                    string queryString = "INSERT INTO Moeda (NomeMoeda,ValorMoeda) VALUES (@1,@2)";
                    SqlCommand cmd = new SqlCommand(queryString, conn);
                    cmd.Parameters.Add("@1", SqlDbType.NVarChar, 90).Value = cad.getNome();
                    cmd.Parameters.Add("@2", SqlDbType.Money, 90).Value = cad.getValor();
                        
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
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Moeda SET NomeMoeda=@1, ValorMoeda=@2 where idMoeda=@0", conn);
                cmd.Parameters.AddWithValue("@1", a.getNome());
                cmd.Parameters.AddWithValue("@2", a.getValor());
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

        public void excluirMoeda(int id)
        {

            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd1 = new SqlCommand("DELETE FROM Moeda WHERE idMoeda=@1", conn);
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
        public CadastroMoeda listarMoeda(int id)
        {
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("select * from Moeda where idMoeda = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    CadastroMoeda a = new CadastroMoeda();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {

                        a.setId(id);

                        a.setId(int.Parse(reader[0].ToString()));
                        a.setNome(reader[1].ToString());
                        a.setValor(Double.Parse(reader[2].ToString()));
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
