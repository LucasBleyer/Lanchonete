using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteDoProgramador.Entidades
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public Fornecedor(int id,string nome, string endereco)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
        }

        public override string ToString() {
            return $"ID = {Id}, Nome = {Nome}, Endereço = {Endereco}";
        }
    }
}
