using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_aniversario
{
    class PessoaController
    {
        public List<PessoaModel> Pessoas = new List<PessoaModel>();

        public void AdicionarPessoa(PessoaModel pessoa)
        {
            Pessoas.Add(pessoa);
        }

        public PessoaModel PesquisarPessoa(string nome)
        {
            foreach(var pessoa in Pessoas)
            {
                if (pessoa.Nome.Equals(nome))
                {
                    return pessoa;
                }
            }

            return null;
        }
        
    }
}
