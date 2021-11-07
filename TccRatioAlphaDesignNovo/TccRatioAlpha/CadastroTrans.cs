using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TccRatioAlpha
{
    class CadastroTrans
    {
        private int Id,idOrigem,idDestino,idMoeda;
        private double Valor;
        private string Origem, Destino, Moeda;
        private DateTime dataTrans;

        public void setId(int id)
        {
            Id = id;
        }

        public int getId()
        {
            return Id;
        }
        public void setidOrigem(int carteira)
        {
            idOrigem = carteira;
        }

        public int getidOrigem()
        {
            return idOrigem;
        }
        public void setidDestino(int carteira)
        {
            idDestino = carteira;
        }

        public int getidDestino()
        {
            return idDestino;
        }
        public void setidMoeda(int idmoeda)
        {
            idMoeda = idmoeda;
        }

        public int getidMoeda()
        {
            return idMoeda;
        }

        public void setValor(double valor)
        {
            Valor = valor;
        }

        public double getValor()
        {
            return Valor;       
        }

        public void setOrigem(string origem)
        {
            Origem = origem;
        }

        public string getOrigem()
        {
            return Origem;
        }

        public void setMoeda(string moeda)
        {
            Moeda = moeda;
        }

        public string getMoeda()
        {
            return Moeda;
        }

        public void setDestino(string destino)
        {
            Destino = destino;
        }

        public string getDestino()
        {
            return Destino;
        }

        public void setdataTrans(DateTime datatrans)
        {
            dataTrans = datatrans;
        }

        public DateTime getdataTrans()
        {
            return dataTrans;
        }

    }
}
