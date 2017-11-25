using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_aniversario
{
    class PessoaModel
    {
        public string Nome { get; }
        public string Sobrenome { get; }
        public string DataNasc { get; }

        public PessoaModel(string nome, string dataNascimento, string sobrenome = "NÃO INFORMADO")
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.DataNasc = dataNascimento;
        }
    }
}
