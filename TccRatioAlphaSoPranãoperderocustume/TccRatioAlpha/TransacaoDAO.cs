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
    class TransacaoDAO
    {
        SqlConnection conn = classeConexão.obterConexao();
        SqlConnection conn1 = classeConexão.obterConexao();
        public void criarTrans(CadastroTrans cad)
        {
            string aux = null;
            SqlCommand cmd1;
            SqlDataReader reader;
            conn = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open)
            {
                try
                {

                    string queryString = "INSERT INTO Transacao (Valor,DataTrans,Origem,TipoMoeda,Destino) VALUES (@1,@2,@3,@4,@5)";
                    SqlCommand cmd = new SqlCommand(queryString, conn);
                    cmd.Parameters.Add("@1", SqlDbType.NVarChar, 90).Value = cad.getValor();
                    cmd.Parameters.Add("@2", SqlDbType.Date, 90).Value = cad.getdataTrans();
                    if (cad.getOrigem() != "")
                    {
                        cmd1 = new SqlCommand("SELECT idCarteira FROM Usuario WHERE Nome=@1", conn1);
                        cmd1.Parameters.Add("@1", SqlDbType.NVarChar, 90).Value = cad.getOrigem();
                        reader = cmd1.ExecuteReader();
                        if (reader.Read())
                            aux = (reader[0].ToString());
                        cmd1.Dispose();
                        reader.Close();
                        cmd.Parameters.Add("@3", SqlDbType.NVarChar, 90).Value = int.Parse(aux);
                    }
                    else
                    {
                        cmd.Parameters.Add("@3", SqlDbType.NVarChar, 90).Value = null;
                    }
                    cmd1 = new SqlCommand("SELECT idMoeda FROM Moeda WHERE NomeMoeda=@1", conn1);
                    cmd1.Parameters.Add("@1", SqlDbType.NVarChar, 90).Value = cad.getMoeda();
                    reader = cmd1.ExecuteReader();
                    if (reader.Read())
                        aux = (reader[0].ToString());
                    cmd1.Dispose();
                    reader.Close();
                    cmd.Parameters.Add("@4", SqlDbType.NVarChar, 90).Value = int.Parse(aux);

                    cmd1 = new SqlCommand("SELECT idCarteira FROM Usuario WHERE Nome=@1", conn1);
                    cmd1.Parameters.Add("@1", SqlDbType.NVarChar, 90).Value = cad.getDestino();
                    reader = cmd1.ExecuteReader();
                    if (reader.Read())
                        aux = (reader[0].ToString());
                    cmd1.Dispose();
                    reader.Close();
                    cmd.Parameters.Add("@5", SqlDbType.NVarChar, 90).Value = int.Parse(aux);

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
        public void atualizarTrans(CadastroTrans a)
        {
            conn = classeConexão.obterConexao();
            getIds(a);
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Transacao SET Valor=@1, DataTrans=@2, Origem=@3, TipoMoeda=@4, Destino=@5 where idTransacao=@0", conn);
                cmd.Parameters.AddWithValue("@1", a.getValor());
                cmd.Parameters.Add("@2", SqlDbType.Date, 90).Value = a.getdataTrans();
                cmd.Parameters.AddWithValue("@3", a.getidOrigem());
                cmd.Parameters.AddWithValue("@4", a.getidMoeda());
                cmd.Parameters.AddWithValue("@5", a.getidDestino());
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
        public void excluirTrans(int id)
        {
            conn = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd1 = new SqlCommand("DELETE FROM Transacao WHERE idTransacao=@1", conn);
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

        public CadastroTrans listarUsu(int id)
        {
            conn = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand("select * from Transacao where idTransacao = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    CadastroTrans a = new CadastroTrans();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        a.setId(int.Parse(reader[0].ToString()));
                        a.setValor(double.Parse(reader[1].ToString()));
                        a.setdataTrans(DateTime.Parse(reader[2].ToString()));
                        cmd.Dispose();
                         cmd = new SqlCommand("SELECT Nome FROM Usuario WHERE idCarteira=@1", conn1);
                        cmd.Parameters.AddWithValue("@1", reader[3]);
                        SqlDataReader reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                            a.setOrigem(reader1[0].ToString());
                        cmd.Dispose();
                        reader1.Close();
                        cmd = new SqlCommand("SELECT NomeMoeda FROM Moeda WHERE idMoeda=@1", conn1);
                        cmd.Parameters.AddWithValue("@1", reader[4]);
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                            a.setMoeda(reader1[0].ToString());
                        cmd.Dispose();
                        reader1.Close();
                        cmd = new SqlCommand("SELECT Nome FROM Usuario WHERE idCarteira=@1", conn1);
                        cmd.Parameters.AddWithValue("@1", reader[5]);
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                            a.setDestino(reader1[0].ToString());
                        cmd.Dispose();
                        reader1.Close();
                        reader.Close();
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
                string queryString = "select Max(idTransacao) from Transacao";

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

        public CadastroTrans getIds(CadastroTrans a)
        {
            conn = classeConexão.obterConexao();
            if (conn.State == ConnectionState.Open)
            {
                string aux = null;
                SqlCommand cmd1;
                SqlDataReader reader;
                conn = classeConexão.obterConexao();
                if (a.getOrigem() != "")
                {
                    cmd1 = new SqlCommand("SELECT idCarteira FROM Usuario WHERE Nome=@1", conn);
                    cmd1.Parameters.Add("@1", SqlDbType.NVarChar, 90).Value = a.getOrigem();
                    reader = cmd1.ExecuteReader();
                    if (reader.Read())
                        aux = (reader[0].ToString());
                    cmd1.Dispose();
                    reader.Close();
                    a.setidOrigem(int.Parse(aux));
                }
                cmd1 = new SqlCommand("SELECT idMoeda FROM Moeda WHERE NomeMoeda=@1", conn);
                cmd1.Parameters.Add("@1", SqlDbType.NVarChar, 90).Value = a.getMoeda();
                reader = cmd1.ExecuteReader();
                if (reader.Read())
                    aux = (reader[0].ToString());
                cmd1.Dispose();
                reader.Close();
                a.setidMoeda(int.Parse(aux));

                cmd1 = new SqlCommand("SELECT idCarteira FROM Usuario WHERE Nome=@1", conn);
                cmd1.Parameters.Add("@1", SqlDbType.NVarChar, 90).Value = a.getDestino();
                reader = cmd1.ExecuteReader();
                if (reader.Read())
                    aux = (reader[0].ToString());
                cmd1.Dispose();
                reader.Close();
                a.setidDestino(int.Parse(aux));

                return a;
            }
            else
            {
                return null;
            }
        }
    }
}
