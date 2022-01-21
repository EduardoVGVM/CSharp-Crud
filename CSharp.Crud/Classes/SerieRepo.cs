using System;
using System.Collections.Generic;
using CSharp.Crud.Interfaces;

namespace CSharp.Crud
{
    public class SerieRepo : IRepositorio<Serie>
    {
        public List<Serie> listaSerie = new List<Serie>();
        public void Inserir(Serie objeto)
        {
            listaSerie.Add(objeto);
        }
        public void Listar()
        {
            return listaSerie;
        }
        public void Atualizar(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }
        public void Excluir(int id)
        {
            listaSerie[id].Excluir();
        }
        public void RetornarPorId(int id)
        {
            return listaSerie[id];
        }
        public void ProxId()
        {
            return listaSerie.Count;
        }
    }
}