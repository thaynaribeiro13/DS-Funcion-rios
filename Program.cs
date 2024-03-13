using System;
using System.Globalization;
using System.Linq;
using Aula03Colecoes.Models;
using Aula03Colecoes.Models.Enuns;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.DataAnnotations;

namespace Aula03Colecoes
{
    class Program
    {
        static List <Funcionario> lista = new List<Funcionario>();

        static void Main(string[] args)
        {
            ExemplosListasColecoes();
        }

        public static void CriarLista()
        {
            Funcionario f1 = new Funcionario();
            f1.Id = 1;
            f1.Nome = "Kayden Grey McLamar";
            f1.Cpf = "12345678910";
            f1.DataAdmissao = DateTime.Parse("01/01/2000");
            f1.Salario = 100.000M;
            f1.TipoFuncionario = TipoFuncionarioEnum.CLT;
            lista.Add(f1);

            Funcionario f2 = new Funcionario(); 
            f2.Id = 2; 
            f2.Nome = "Zachary Grant Blackhill"; 
            f2.Cpf = "01987654321";
            f2.DataAdmissao = DateTime.Parse("30/06/2002"); 
            f2.Salario = 150.000M; 
            f2.TipoFuncionario = TipoFuncionarioEnum.CLT; 
            lista.Add(f2); 
            
            Funcionario f3 = new Funcionario(); 
            f3.Id = 3; 
            f3.Nome = "Violette Aster Delvis"; 
            f3.Cpf = "135792468"; 
            f3.DataAdmissao = DateTime.Parse("01/11/2003"); 
            f3.Salario = 70.000M; 
            f3.TipoFuncionario = TipoFuncionarioEnum.Aprendiz; 
            lista.Add(f3); 
            
            Funcionario f4 = new Funcionario(); 
            f4.Id = 4; 
            f4.Nome = "Lukas Ayano McGray"; 
            f4.Cpf = "246813579"; 
            f4.DataAdmissao = DateTime.Parse("15/09/2005"); 
            f4.Salario = 80.000M; 
            f4.TipoFuncionario = TipoFuncionarioEnum.Aprendiz; 
            lista.Add(f4); 
            
            Funcionario f5 = new Funcionario(); 
            f5.Id = 5; 
            f5.Nome = "Eduarda Santana"; 
            f5.Cpf = "246813579"; 
            f5.DataAdmissao = DateTime.Parse("20/10/1998"); 
            f5.Salario = 90.000M; 
            f5.TipoFuncionario = TipoFuncionarioEnum.Aprendiz; 
            lista.Add(f5);

            Funcionario f6 = new Funcionario(); 
            f6.Id = 6; 
            f6.Nome = "Arzaylea Rodriguez"; 
            f6.Cpf = "246813579"; 
            f6.DataAdmissao = DateTime.Parse("13/12/1997"); 
            f6.Salario = 300.000M; 
            f6.TipoFuncionario = TipoFuncionarioEnum.CLT; 
            lista.Add(f6);
        }

        public static void ExibirLista()
        {
            string dados = "";
            for (int i = 0; i < lista.Count; i++)
            {
                dados += "=============================\n";
                dados += string.Format ("Id: {0} \n", lista[i].Id);
                dados += string.Format ("Nome: {0} \n", lista[i].Nome);
                dados += string.Format ("CPF: {0} \n", lista[i].Cpf);
                dados += string.Format ("Admissão: {0:dd/MM/yyyy} \n", lista[i].DataAdmissao);
                dados += string.Format ("Salário: {0:c2} \n", lista[i].Salario);
                dados += string.Format ("Tipo: {0} \n", lista[i].TipoFuncionario);
                dados += "=============================\n";

            }
            Console.WriteLine(dados);
        }

        public static void ObterPorId()
        {
                lista = lista.FindAll(x => x.Id == 1);
                ExibirLista();
        }

        public static void ExemplosListasColecoes()         
        { 
            Console.WriteLine("==================================================");
            Console.WriteLine("****** Exemplos - Aula 03 Listas e Coleções ******"); 
            Console.WriteLine("=================================================="); 
            CriarLista(); 
            int opcaoEscolhida = 0; 
            do            
            { 
                Console.WriteLine("==================================================");
                Console.WriteLine("---Digite o número referente a opção desejada: ---");
                Console.WriteLine("1 - Obter Por Id");
                Console.WriteLine("2 - Adicionar funcionário");
                Console.WriteLine("3 - Obter por id digitado");
                Console.WriteLine("4 - Obter funcionário pelo nome");
                Console.WriteLine("5 - Obter por salário digitado");
                Console.WriteLine("6 - Obter lista por numeração específica");
                Console.WriteLine("7 - Obter estatísticas de funcionários e seus salários");
                Console.WriteLine("8 - Validar salário ou data de admissão");
                Console.WriteLine("9 - Validar nome do funcionário");
                Console.WriteLine("10 - Ordem dos salários e funcionários com Id inferior a 4");
                Console.WriteLine("=================================================="); 
                Console.WriteLine("-----Ou tecle qualquer outro número para sair-----"); 
                Console.WriteLine("==================================================");       
                
                opcaoEscolhida = int.Parse(Console.ReadLine());
                string mensagem = string.Empty; 
                switch (opcaoEscolhida)                 
                { 
                    case 1: 
                    ObterPorId();           
                    break;

                    case 2:
                    AdicionarFuncionario();
                    break;

                    case 3:
                    Console.WriteLine("Digite o Id do funcionário que você deseja buscar:");
                    int id = int.Parse(Console.ReadLine());
                    ObterPorIdDigitado(id);
                    break;

                    case 4:
                    Console.WriteLine("Digite o nome do funcionário:");
                    string Nome = Console.ReadLine();
                    ObterPorNome(Nome);
                    break;

                    case 5:
                    Console.WriteLine("Digite o salário para obter um funcionário:");
                    decimal Salario = decimal.Parse(Console.ReadLine());
                    ObterPorSalario(Salario);
                    break;

                    case 6:
                    Console.WriteLine("Digite a numeração desejada:");
                    int Tipo = int.Parse(Console.ReadLine());
                    ObterPorTipo(Tipo);
                    break;

                    case 7:
                    ObterEstatisticas();
                    break;

                    case 8:
                    Console.WriteLine("Digite o salário ou sua data de admissão:");
                    decimal salario = decimal.Parse(Console.ReadLine());
                    DateTime dataAdmissao = DateTime.Parse(Console.ReadLine());
                    ValidarSalarioAdmissao(salario, dataAdmissao);
                    break;

                    case 9:
                    Console.WriteLine("Digite seu nome:");
                    string nome = Console.ReadLine();
                    ValidarNome(nome);
                    break;

                    case 10:
                    Console.WriteLine("Ordem decrescente dos salários");
                    decimal valor = decimal.Parse(Console.ReadLine());
                    ObterFuncionariosRecentes(valor);
                    break;

                    default: 
                    Console.WriteLine("Saindo do sistema...."); 
                    break;
                }             
                
            } 
                    while (opcaoEscolhida >= 1 && opcaoEscolhida <= 10); 
                    Console.WriteLine("=================================================="); 
                    Console.WriteLine("* Obrigado por utilizar o sistema e volte sempre *"); 
                    Console.WriteLine("==================================================");                   
        } 

            public static void ObterPorIdDigitado(int id)
        {
                lista = lista.FindAll(x => x.Id == id);
                ExibirLista();
        }

            public static void AdicionarFuncionario()
            {
                Funcionario f = new Funcionario();

                Console.WriteLine("Digite o nome:");
                f.Nome = Console.ReadLine();

                Console.WriteLine("Digite o salário:");
                f.Salario = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite a data de admissão:");
                f.DataAdmissao = DateTime.Parse(Console.ReadLine());

                if (string.IsNullOrEmpty(f.Nome))
                {
                    Console.WriteLine("O nome deve ser preenchido");
                    return;
                }
                else if (f.Salario == 0)
                {
                    Console.WriteLine("Valor do salário não pode ser 0");
                    return;
                }
                else
                {
                    lista.Add(f);
                    ExibirLista();
                }
            }

            public static void ObterPorSalario(decimal valor)
            {
                lista = lista.FindAll(x => x.Salario >= valor);
                ExibirLista();
            }

            //EXERCICÍOS

            //Letra A
            public static void ObterPorNome(string nome)
            {
                Funcionario fBusca = lista.Find(x => x.Nome == nome);
                if (nome == nome)
                {
                    Console.WriteLine($"Funcionário encontrado: {fBusca.Nome}");
                }
                else
                {
                    Console.WriteLine("Nome não encontrado.");
                    return;
                }
                ExibirLista();
            }

            //Letra B
            public static void ObterFuncionariosRecentes(decimal Salario)
            {
                lista.RemoveAll(x => x.Id < 4);
                lista = lista.OrderBy(x => x.Salario).ToList();
                ExibirLista();
            }
                
            //Letra C
            public static void ObterEstatisticas()
            {
                int qtd = lista.Count();
                Console.WriteLine($"Existem {qtd} funcionários.");
                decimal somatorio = lista.Sum(x => x.Salario);
                Console.WriteLine(string.Format("A soma dos salários é {0:c2}.", somatorio));
            }

            //Letra D
            public static void ValidarSalarioAdmissao(decimal Salario, DateTime dataAdmissao)
            {
                if (Salario <= 0)
                {
                    Console.WriteLine("O salário não é válido.");
                }
                else if (dataAdmissao < DateTime.Now)
                {
                    Console.WriteLine("A data de admissão não corresponde.");
                }
                ExibirLista();
            }

            //Letra E
            public static void ValidarNome(string nome)
            {
                int Lenght = nome.Length;
                if (nome.Length <= 2)
                {
                    Console.WriteLine("O nome não é válido.");
                }
                else
                {
                    Console.WriteLine("Nome cadastrado.");
                }
            }

            //Letra F
            public static void ObterPorTipo(int tipo)
            {
            if (tipo == 1)
            {
                lista = lista.FindAll(x => x.TipoFuncionario == TipoFuncionarioEnum.CLT).ToList();
                ExibirLista();
            }
            else if (tipo == 2)
            {
                lista = lista.FindAll(x => x.TipoFuncionario == TipoFuncionarioEnum.Aprendiz).ToList();
                ExibirLista();
            }
            else
            {
                Console.WriteLine("Esse número não é válido.");
                return;
            }
            }
        }
    }    