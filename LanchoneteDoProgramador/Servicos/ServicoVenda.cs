using LanchoneteDoProgramador.Entidades;
using LanchoneteDoProgramador.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteDoProgramador.Servicos
{
    public class ServicoVenda
    {
        RepositorioProduto repositorioProduto;
        RepositorioVenda repositorioVenda;
        Linguagem linguagem;

        public ServicoVenda(RepositorioVenda repositorioVenda, RepositorioProduto repositorioProduto, Linguagem linguagem)
        {
            this.repositorioProduto = repositorioProduto;
            this.repositorioVenda = repositorioVenda;
            this.linguagem = linguagem;

        }

        public void ListarVendas() {
            
            var vendas = repositorioVenda.BuscarTodos();

            foreach (var v in vendas)
            {
                Console.WriteLine(v);
            }
        }

        public void CadastrarVenda()
        {

            int id = repositorioVenda.BuscarTodos().Count + 1;

            Console.WriteLine(linguagem.GetMensagem("CadastroVenda"));
            Console.WriteLine("ID = " + id.ToString());

            bool loop = true;
            List<Produto> produtos = new List<Produto>();
            while (loop)
            {
                Console.WriteLine(linguagem.GetMensagem("IdProduto"));
                int idP = Convert.ToInt32(Console.ReadLine());

                Produto p = repositorioProduto.BuscarPorId(idP);
                produtos.Add(p);

                Console.WriteLine(linguagem.GetMensagem("SelecionarNovoProduto"));
                string resposta = Console.ReadLine();
                if (resposta == "n" || resposta == "nao" || resposta == "não" || resposta == "no")
                {
                    loop = false;
                }
                
            }


            Console.WriteLine(linguagem.GetMensagem("Cpf"));
            string cpf = Console.ReadLine();

            Console.WriteLine(linguagem.GetMensagem("FormaPagamento"));
            string formaPagamento = Console.ReadLine();

            Venda venda = new Venda(id, produtos, cpf, formaPagamento);

            repositorioVenda.Adicionar(venda);
        }

        public void ExcluirVenda()
        {
            Console.WriteLine(linguagem.GetMensagem("DigiteID"));
            int id = Convert.ToInt32(Console.ReadLine());

            var venda = repositorioVenda.BuscarPorId(id);

            repositorioVenda.Remover(venda);
        }
    }
}
