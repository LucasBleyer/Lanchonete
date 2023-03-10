using LanchoneteDoProgramador.Entidades;
using LanchoneteDoProgramador.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteDoProgramador.Servicos
{
    public class ServicoProduto
    {
        RepositorioProduto repositorioProduto;
        RepositorioFornecedor repositorioFornecedor;
        Linguagem linguagem;
        public ServicoProduto(RepositorioProduto repositorioProduto, RepositorioFornecedor repositorioFornecedor, Linguagem linguagem)
        {
            this.repositorioProduto = repositorioProduto;
            this.repositorioFornecedor = repositorioFornecedor;
            this.linguagem = linguagem;

        }

        public void ListarProdutos()
        {
            var produtos = repositorioProduto.BuscarTodos();

            foreach (var p in produtos)
            {
                Console.WriteLine(p);
            }
        }

        public void CadastrarProduto()
        {
            int id = repositorioProduto.BuscarTodos().Count + 1;

            Console.WriteLine(linguagem.GetMensagem("CadastroProduto"));
            Console.WriteLine("ID = " + id.ToString());
            Console.WriteLine(linguagem.GetMensagem("Titulo"));
            string titulo = Console.ReadLine();
            Console.WriteLine(linguagem.GetMensagem("Valor"));
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(linguagem.GetMensagem("DigiteIdFornecedor"));
            int idF = Convert.ToInt32(Console.ReadLine());
            var fornecedor = repositorioFornecedor.BuscarPorId(idF);

            int quantidade = repositorioProduto.BuscarTodos().Count;

            Produto produto = new Produto(id, titulo, valor, quantidade, fornecedor);

            repositorioProduto.Adicionar(produto);
        }

        public void ExcluirProduto()
        {
            Console.WriteLine(linguagem.GetMensagem("DigiteID"));
            int id = Convert.ToInt32(Console.ReadLine());

            var produto = repositorioProduto.BuscarPorId(id);

            repositorioProduto.Remover(produto);
        }
    }
}
