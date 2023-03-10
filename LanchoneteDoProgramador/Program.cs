using LanchoneteDoProgramador;
using LanchoneteDoProgramador.Repositorios;
using LanchoneteDoProgramador.Servicos;
using LanchoneteDoProgramador.Servicos;
using System.Security.Cryptography.X509Certificates;

namespace LanchoneteDoProgramador
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string linguagemSelecionada = "en";

            if (args.Length > 0)
            {
                linguagemSelecionada = args[0];
            }

            Linguagem linguagem = new Linguagem(linguagemSelecionada);

            var repositorioFornecedor = new RepositorioFornecedor();
            var repositorioVenda = new RepositorioVenda();
            var repositorioProduto = new RepositorioProduto();

            var servicoFornecedor = new ServicoFornecedor(repositorioFornecedor, linguagem);
            var servicoProduto = new ServicoProduto(repositorioProduto, repositorioFornecedor, linguagem);
            var servicoVenda = new ServicoVenda(repositorioVenda, repositorioProduto, linguagem);

            while (true)
            {
                Console.WriteLine(linguagem.GetMensagem("SelecioneOpcaoMenu"));
                Console.WriteLine("1 - " + linguagem.GetMensagem("Produtos"));
                Console.WriteLine("2 - " + linguagem.GetMensagem("Fornecedores"));
                Console.WriteLine("3 -  " + linguagem.GetMensagem("Vendas"));
                Console.WriteLine("4 -  " + linguagem.GetMensagem("GerarPDF"));
                Console.WriteLine("0 - " + linguagem.GetMensagem("Sair"));

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        MenuProdutos(servicoProduto, linguagem);
                        break;
                    case "2":
                        MenuFornecedores(servicoFornecedor, linguagem);
                        break;
                    case "3":
                        MenuVendas(servicoVenda, linguagem);
                        break;
                    case "4":
                        GerarPDF();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine(linguagem.GetMensagem("OpcaoInvalida"));
                        break;
                }

                Console.WriteLine();
            }

        }

        static void MenuProdutos(ServicoProduto servicoProduto, Linguagem linguagem)
        {
            while (true)
            {
                Console.WriteLine(linguagem.GetMensagem("SelecioneOpcaoMenu"));
                Console.WriteLine("1 - " + linguagem.GetMensagem("ListarProdutos"));
                Console.WriteLine("2 - " + linguagem.GetMensagem("CadastrarProduto"));
                Console.WriteLine("3 - " + linguagem.GetMensagem("ExcluirProduto"));
                Console.WriteLine("0 - " + linguagem.GetMensagem("Voltar"));

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        servicoProduto.ListarProdutos();
                        break;
                    case "2":
                        servicoProduto.CadastrarProduto();
                        break;
                    case "3":
                        servicoProduto.ExcluirProduto();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine(linguagem.GetMensagem("OpcaoInvalida"));
                        break;
                }

                Console.WriteLine();
            }
        }

        static void MenuFornecedores(ServicoFornecedor servicoFornecedor, Linguagem linguagem)
        {
            while (true)
            {
                Console.WriteLine(linguagem.GetMensagem("SelecioneOpcaoMenu"));
                Console.WriteLine("1 - " + linguagem.GetMensagem("ListarFornecedores"));
                Console.WriteLine("2 - " + linguagem.GetMensagem("CadastrarFornecedor"));
                Console.WriteLine("3 - " + linguagem.GetMensagem("ExcluirFornecedor"));
                Console.WriteLine("0 - " + linguagem.GetMensagem("Voltar"));

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        servicoFornecedor.ListarFornecedores();
                        break;
                    case "2":
                        servicoFornecedor.CadastrarFornecedor();
                        break;
                    case "3":
                        servicoFornecedor.ExcluirFornecedor();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine(linguagem.GetMensagem("OpcaoInvalida"));
                        break;
                }

                Console.WriteLine();
            }
        }
        static void MenuVendas(ServicoVenda servicoVenda, Linguagem linguagem)
        {
            while (true)
            {
                Console.WriteLine("Selecione a opção desejada:");
                Console.WriteLine("1 - " + linguagem.GetMensagem("ListarVendas"));
                Console.WriteLine("2 - " + linguagem.GetMensagem("CadastrarVenda"));
                Console.WriteLine("3 - " + linguagem.GetMensagem("ExcluirVenda"));
                Console.WriteLine("0 - " + linguagem.GetMensagem("Voltar"));

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        servicoVenda.ListarVendas();
                        break;
                    case "2":
                        servicoVenda.CadastrarVenda();
                        break;
                    case "3":
                        servicoVenda.ExcluirVenda();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine(linguagem.GetMensagem("OpcaoInvalida"));
                        break;
                }

                Console.WriteLine();
            }
        }

        public static void GerarPDF()
        {

        }
    } 
}

