using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TccRatioAlpha
{
    class CadastroTags
    {
        int id;
        string Nome, Desc;
        
        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return id;
        }

        public void setNome(string nome)
        {
            Nome = nome;
        }
        public string getNome()
        {
            return Nome;
        }


        public void setDesc(string desc)
        {
            Desc = desc;
        }
        public string getDesc()
        {
            return Desc;
        }

    }
}
