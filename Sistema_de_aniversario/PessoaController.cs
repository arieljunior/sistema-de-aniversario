using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_aniversario
{
    class PessoaController
    {
        private List<PessoaModel> Pessoas = new List<PessoaModel>();

        public void AdicionarPessoa(PessoaModel pessoa)
        {
            Pessoas.Add(pessoa);
        }

        public PessoaModel PesquisarPessoa(string nome)
        {
            foreach(var pessoa in Pessoas)
            {
                if (pessoa.getNome().Equals(nome))
                {
                    return pessoa;
                }
            }

            return null;
        }

        public int calcularData(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Today;

            string dia = (dataNascimento.Day).ToString();
            string mes = (dataNascimento.Month).ToString();
            string ano = (DateTime.Today.Year).ToString();

            TimeSpan tempo = new TimeSpan();
            
 			if (dataNascimento.Month == dataAtual.Month)
            {
                if (dataNascimento.Day == dataAtual.Day)
                {
                	Console.WriteLine("\nPARABÉNS, SEU ANIVERSÁRIO É HOJE!!!!");
                    // variavel tempo fica null
                }
                else if (dataNascimento.Day > dataAtual.Day)
                {
                    tempo = dataAtual.Subtract(DateTime.Parse(dia + "/" + mes + "/" + ano));
                }
            }
            else if (dataNascimento.Month > dataAtual.Month)
            {
                tempo = dataAtual.Subtract(DateTime.Parse(dia + "/" + mes + "/" + ano));
            }
            else
            {
            	int anoSeguinte = int.Parse(ano) + 1;
                tempo = dataAtual.Subtract(DateTime.Parse(dia + "/" + mes + "/" + anoSeguinte));
            }

            return tempo.Days;
        }
        
    }
}
