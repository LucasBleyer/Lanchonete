using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteDoProgramador.Repositorios
{
    public class RepositorioGenerico<T>
    {
        public List<T> _listaDeObjetos;

        public RepositorioGenerico()
        {
            _listaDeObjetos = new List<T>();
        }

        public void Adicionar(T objeto)
        {
            _listaDeObjetos.Add(objeto);
        }

        public void Remover(T objeto)
        {
            _listaDeObjetos.Remove(objeto);
        }

        public void Atualizar(T objeto)
        {
            // Implementação da atualização
        }

        public List<T> BuscarTodos()
        {
            return _listaDeObjetos;
        }

    }
}
