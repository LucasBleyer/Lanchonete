using LanchoneteDoProgramador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteDoProgramador.Repositorios
{
    public class RepositorioFornecedor : RepositorioGenerico<Fornecedor>
    {

        public Fornecedor BuscarPorId(int id)
        {
           return (Fornecedor) _listaDeObjetos.Find(x => x.Id == id);
        }
    }
}
