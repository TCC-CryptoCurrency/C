using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TccRatioAlpha
{
    class CadastroMoeda
    {
        private int Id;
        private string Nome ;
        private Double Valor;

        public void setId(int id)
        {
            Id = id;
        }

        public int getId()
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
    }
}
