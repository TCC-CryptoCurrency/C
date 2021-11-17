using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TccRatioAlpha
{
    class CadastroNoticia
    {
        private int Id = 0; 
        private string Titulo, Descricao,Link;
        private DateTime Data;

        public void setId(int id)
        {
            Id = id;
        }

        public int getId()
        {
            return Id;
        }

        public void setTitulo(string titulo) {
            Titulo = titulo;
        }

        public string getTitulo() {
            return Titulo;
        }

        public void setLink(string link)
        {
            Link = link;
        }

        public string getLink()
        {
            return Link;
        }


        public void setDescricao(string descricao) {
            Descricao = descricao;
        }

        public string getDescricao()
        {
            return Descricao;
        }

        public void setData(DateTime data)
        {
            Data = data;
        }

        public DateTime getData()
        {
            return Data;
        }

    }
}
