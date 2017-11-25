using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_aniversario
{
    class PessoaController
    {
        public List<PessoaModel> pessoas = new List<PessoaModel>();

        public void AdicionarPessoa(PessoaModel pessoa)
        {
            pessoas.Add(pessoa);
        }

        public void PesquisarPessoa(string nome)
        {

        }
        
    }
}
