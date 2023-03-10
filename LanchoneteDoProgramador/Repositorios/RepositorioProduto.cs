using LanchoneteDoProgramador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteDoProgramador.Repositorios
{
    public class RepositorioProduto : RepositorioGenerico<Produto>
    {
        public Produto BuscarPorId(int id)
        {
            return (Produto)_listaDeObjetos.Find(x => x.Id == id);
        }
    }
}
