using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TccRatioAlpha
{
    class Cadastro
    {
        private int Id;
        private string Nome, Email, Cpf, Senha,aux;
        private DateTime Data;

        public void setNome(string nome) {
            Nome = nome;
        }

        public string getNome() {
            return Nome;
        }

        public void setEmail(string email) {
            Email = email;
        }

        public string getEmail()
        {
            return Email;
        }
        public void setCpf(string cpf)
        {
            Cpf = cpf;
        }

        public string getCpf()
        {
            return Cpf;
        }
        public void setSenha(string senha) {
            Senha = senha;
        }
        public string getSenha()
        {
            return Senha;
        }
        public void setData(DateTime data)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("pt-BR");
            aux = Convert.ToString(data);
            Data = DateTime.Parse(aux, culture);
            aux = Convert.ToString(Data.Day + "." + Data.Month + "." + data.Year);
        }
        public string getData()
        {
            return aux;
        }
        public void setId(int Id)
        {
            this.Id = Id;
        }

        public int getId()
        {
            return Id;
        }
    }
}
