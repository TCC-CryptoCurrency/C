using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TccRatioAlpha
{
    public partial class ucGrafico : UserControl
    {
        CadastroMoeda a = new CadastroMoeda();
        MoedaDAO b = new MoedaDAO();
        public ucGrafico()
        {
            InitializeComponent();
            checkbox();
        }
        private void checkbox()
        {
            int count = b.quantidade();

            for (int i = 0; i <= count; i++)
            {
                if (b.listarMoeda(i) != null)
                {
                    CadastroMoeda A = b.listarMoeda(i);

                    cbMoeda.Items.Add(A.getNome());
                }
            }
        }
        private void listarHistorico(int id) 
        {
            DateTime antigo = b.getOldest(id);
            while (antigo != DateTime.Today)
            {
                SqlConnection conn = classeConexão.obterConexao();
                string queryString = "select DataRegistro, ValorData from HistoricoMoeda where idMoeda = @a and DataRegistro=@b";
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@a", id);

                cmd.Parameters.AddWithValue("@b", antigo);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    chart1.Series["Preco"].Points.AddXY(reader[0], reader[1]);
                }
                antigo = antigo.AddDays(1);
                cmd.Dispose();
                reader.Close();
                conn.Close();
            }
            
        }

        private void txtChecar_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            a.setNome(cbMoeda.SelectedItem.ToString());
            int aux = b.getIds(a);
            chart1.Series.Add("Preco");
            chart1.Series["Preco"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Preco"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            listarHistorico(aux);

        }
    }
}
