using LanchoneteDoProgramador.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteDoProgramador.Entidades
{
    public class Venda
    {

        public int Id { get; set; }
        public List<Produto> Produtos { get; set; }
        public string FormaDePagamento { get; set; }
        public string CpfCliente { get; set; }


        public Venda(int id, List<Produto> produtos, string formaPagamento, string cpfCliente)
        {
            Id = id; Produtos = produtos; FormaDePagamento = formaPagamento; CpfCliente = cpfCliente;
        }


        public decimal CalcularValorTotal()
        {
            decimal valorTotal = 0;
            foreach (var produto in Produtos)
            {
                valorTotal += produto.ValorUnitario;
            }
            return valorTotal;
        }

        public override string ToString()
        {

            string a = $"ID = {Id}, ";
            foreach (var produto in Produtos) { 
                a = a+ produto.ToString() + ", "; 
            }

            a = a + $"Forma de Pagamento = {FormaDePagamento}, CPF = {CpfCliente}";

            return a;
        }
    }

}
