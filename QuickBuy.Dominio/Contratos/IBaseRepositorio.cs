using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Contratos
{
    //                                  Está definindo que a interface IBaseRposositori vai trabalhar apenas com TEntity
    //                                  A interface IBaseRposositori herda de outra interface a IDisposable
    //                                  Esta dizendo que TEntity é um class
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity ObterId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);
    }
}
