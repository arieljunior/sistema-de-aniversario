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
                    default:
                        Console.WriteLine("opção inválida");
                        break;
                }

            } while (menu);
        }

        public void ViewAddPessoa()
        {
            Console.Clear();
            Console.WriteLine("----------Nova Pessoa----------");
            Console.WriteLine("Informe os dados abaixo\n");
            
            Console.WriteLine("*Nome e data são obrigatórios\n A data deve ser separada por barra (/), espaço ou virgula(,).\n Exemplo: dd/mm/yyyy *\n");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Sobrenome: ");
            string sobreNome = Console.ReadLine();

            Console.Write("Data de nascimento: ");
            
            try{
            	
            	DateTime DataNascimento = DateTime.Parse(Console.ReadLine());
            	
            	if ((nome != "") && (DataNascimento != null))
            	{
                	if (sobreNome != "")
                	{
                   		PessoaModel pessoa = new PessoaModel(nome, DataNascimento, sobreNome);
                   		pController.AdicionarPessoa(pessoa);
                	}
                	else
                	{
                   		PessoaModel pessoa = new PessoaModel(nome, DataNascimento);
                   		pController.AdicionarPessoa(pessoa);
                	}
                	
                	Console.WriteLine("-----------------------------------");
                	Console.WriteLine("| Usuário cadastrado com sucesso |");
                	Console.WriteLine("-----------------------------------");
            	}
            	else
            	{
                	Console.WriteLine("--------------------------------------------------------");
                	Console.WriteLine("| Usuário não cadastrado.                              |");
                	Console.WriteLine("| É necessário preencher o nome e a data de nascimento |");
                	Console.WriteLine("--------------------------------------------------------");
            	}
            }
            catch(Exception ex){
            	Console.WriteLine("-----------------------------------");
                Console.WriteLine("| Usuário não cadastrado.         |");
                Console.WriteLine("| Formato da data inválido        |");
                Console.WriteLine("-----------------------------------");
            	Console.WriteLine("\n Mais informações: "+ex);
            	
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
                Console.WriteLine("**Dados da pessoa encontrada**\n");
                Console.WriteLine($"Nome: {pessoaEncontrada.getNome()}");
                Console.WriteLine($"Sobrenome: {pessoaEncontrada.getSobrenome()}");
                Console.WriteLine($"Data de nascimento: {pessoaEncontrada.getDataNascimento()}");

                int diasFaltando = pController.calcularData(pessoaEncontrada.getDataNascimento());

                Console.WriteLine($"Faltam {diasFaltando*(-1)} dias para o seu aniversário");
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
