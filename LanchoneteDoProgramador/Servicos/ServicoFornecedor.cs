using LanchoneteDoProgramador.Entidades;
using LanchoneteDoProgramador.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteDoProgramador.Servicos
{
    public class ServicoFornecedor
    {
        RepositorioFornecedor repositorioFornecedor;
        Linguagem linguagem;

        public ServicoFornecedor(RepositorioFornecedor repositorioFornecedor, Linguagem linguagem)
        {
            this.repositorioFornecedor = repositorioFornecedor;
            this.linguagem = linguagem;

        }

        public void ListarFornecedores()
        {
            var fornecedores = repositorioFornecedor.BuscarTodos();

            foreach (var f in fornecedores)
            {
                Console.WriteLine(f);
            }
        }

        public void CadastrarFornecedor()
        {
            int id = repositorioFornecedor.BuscarTodos().Count + 1;

            Console.WriteLine(linguagem.GetMensagem("CadastroFornecedor"));
            Console.WriteLine("ID = " + id.ToString());
            Console.WriteLine(linguagem.GetMensagem("Nome"));
            string nome = Console.ReadLine();
            Console.WriteLine(linguagem.GetMensagem("Endereco"));
            string endereco = Console.ReadLine();

            Fornecedor fornecedor = new Fornecedor(id, nome, endereco);

            repositorioFornecedor.Adicionar(fornecedor);
        }

        public void ExcluirFornecedor()
        {
            Console.WriteLine(linguagem.GetMensagem("DigiteID"));
            int id = Convert.ToInt32(Console.ReadLine());

            var f = repositorioFornecedor.BuscarPorId(id);

            repositorioFornecedor.Remover(f);
        }
    }
}
