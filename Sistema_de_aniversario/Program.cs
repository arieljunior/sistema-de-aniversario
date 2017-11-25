using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_aniversario
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.MostrarMenu();
            
        }

        public void MostrarMenu()
        {
            int opcao;
            bool menu = true;

            do
            {
                Console.Clear();
                Console.WriteLine("----------- |Sistema de Aniversariante| -----------");
                Console.WriteLine("1 - Pesquisar pessoas");
                Console.WriteLine("2 - Adicionar nova Pessoa");
                Console.WriteLine("3 - Sair");
                Console.Write("Digite uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        
                        break;
                    case 2:
                        ViewAddPessoa();
                        break;
                    case 3:
                        Console.WriteLine("saindo...");
                        menu = false;
                        Console.ReadKey();
                        break;
                }

            } while (menu);
        }

        public void ViewAddPessoa()
        {
            Console.Clear();
            Console.WriteLine("----------Nova Pessoa----------");
            Console.WriteLine("Informe os dados abaixo:");

            Console.Write("(Obrigatório) Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Sobrenome: ");
            string sobreNome = Console.ReadLine();

            Console.Write("(Obrigatório) Data de aniversário no formato dd/mm/yyyy: ");
            string dataAniversario = Console.ReadLine();

            if ((nome != null) && (dataAniversario != null))
            {
                if (sobreNome != null)
                {
                    PessoaController pController = new PessoaController();
                    PessoaModel pessoa = new PessoaModel(nome, dataAniversario, sobreNome);
                    pController.AdicionarPessoa(pessoa);
                }
                else
                {
                    PessoaController pController = new PessoaController();
                    PessoaModel pessoa = new PessoaModel(nome, dataAniversario);
                    pController.AdicionarPessoa(pessoa);
                }
            }

            Console.WriteLine("Precione qualquer tecla para voltar");
            Console.ReadKey();
        }

        public void ViewPesquisarPessoa()
        {
            Console.Clear();
            Console.WriteLine("----------Nova Pessoa----------");
            Console.Write("Informe o nome da pessoa cadastrada: ");
            string nome = Console.ReadLine();



        }
    }
}
