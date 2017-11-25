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

        PessoaController pController = new PessoaController();

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
                        ViewPesquisarPessoa();
                        break;
                    case 2:
                        ViewAddPessoa();
                        break;
                    case 3:
                        Console.WriteLine("saindo...");
                        menu = false;
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

            if ((nome != "") && (dataAniversario != ""))
            {
                if (sobreNome != "")
                {
                    PessoaModel pessoa = new PessoaModel(nome, dataAniversario, sobreNome);
                    pController.AdicionarPessoa(pessoa);
                }
                else
                {
                    PessoaModel pessoa = new PessoaModel(nome, dataAniversario);
                    pController.AdicionarPessoa(pessoa);
                }

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| Usuário cadastrado com sucesso |");
                Console.WriteLine("-----------------------------------");
            }
            else
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("| Usuário não cadastrado.         |");
                Console.WriteLine("| Preencha os campos obrigatórios |");
                Console.WriteLine("-----------------------------------");
            }

            Console.WriteLine("\nPrecione qualquer tecla para voltar");
            Console.ReadKey();
        }

        public void ViewPesquisarPessoa()
        {
            Console.Clear();
            Console.WriteLine("----------Pesquisar Pessoa----------");
            Console.Write("Informe o nome da pessoa cadastrada: ");
            string nome = Console.ReadLine();

            PessoaModel pessoaEncontrada = pController.PesquisarPessoa(nome);

            if (pessoaEncontrada != null)
            {
                Console.WriteLine("**Dados da pessoa encontrada**");
                Console.WriteLine($"Nome: {pessoaEncontrada.Nome}");
                Console.WriteLine($"Sobrenome: {pessoaEncontrada.Sobrenome}");
                Console.WriteLine($"Data de nascimento: {pessoaEncontrada.DataNasc}");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado ou não cadastrado");
            }

            Console.WriteLine("\nPrecione qualquer tecla para voltar");
            Console.ReadKey();
        }
    }
}
