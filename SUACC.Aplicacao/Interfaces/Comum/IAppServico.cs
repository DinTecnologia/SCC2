using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;

namespace SUACC.Aplicacao.Interfaces
{
    public interface IAppServico<TEntity> : IDisposable where TEntity : class
    {
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        IEnumerable<TEntity> ObterPor(object @where = null, object order = null);
        ValidationResult Adicionar(TEntity entity);
        ValidationResult Atualizar(TEntity entity);
        ValidationResult Deletar(TEntity entity);
    }
}
