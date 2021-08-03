using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TccRatioAlpha
{
    class Login
    {
        public string Usuario, Senha;
        public void setUsuario(string usuario) {
            Usuario = usuario;
        }
        public string getUsuario() {
            return Usuario;
        }
        public void setSenha(string senha) {
            Senha = senha;
        }
        public string getSenha() {
            return Senha;
        }

        public bool Verifica()
        {
            bool result = false;
            using (SqlConnection cn = classeConexão.obterConexao())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select Nome from Usuario where Email = '" + getUsuario() + "' and Senha = '" + getSenha() + "' ;", cn);
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
            return result;
        }
    }   
}
