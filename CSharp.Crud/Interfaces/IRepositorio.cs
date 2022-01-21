using System.Collections.Generic;

namespace CSharp.Crud.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Listar();
         T RetornaPorId(int id);
        void Inserir(T entidade);
        void Excluir(int id);
        void Atualizar(int id, T entidade);
        int ProxId();
    }
}