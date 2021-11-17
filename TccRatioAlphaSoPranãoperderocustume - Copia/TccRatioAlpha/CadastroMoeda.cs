using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TccRatioAlpha
{
    class CadastroMoeda
    {
        private int Id,IdHistorico;
        private string Nome ;
        private Double Valor;
        private DateTime Att;

        public void setId(int id)
        {
            Id = id;
        }

        public int getId()
        {
            return Id;
        }

        public void setIdHistorico(int id)
        {
            IdHistorico = id;
        }

        public int getIdHistorico()
        {
            return Id;
        }
        public void setNome(string nome)
        {
            Nome = nome;
        }

        public string getNome()
        {
            return Nome;
        }
        public void setValor(Double valor)
        {
            Valor = valor;
        }

        public Double getValor()
        {
            return Valor;
        }
        public void setAttt(DateTime att)
        {
            Att = att;
        }

        public DateTime getAtt()
        {
            return Att;
        }
    }
}
