using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_aniversario
{
    class PessoaModel
    {
        private string Nome;
        private string Sobrenome;
        private DateTime DataNascimento;

        public PessoaModel(string nome, DateTime dataNascimento, string sobrenome = "NÃO INFORMADO")
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.DataNascimento = dataNascimento;
        }

        public string getNome()
        {
            return Nome;
        }

        public string getSobrenome()
        {
            return Sobrenome;
        }
        public DateTime getDataNascimento()
        {
            return DataNascimento;
        }
    }
}
