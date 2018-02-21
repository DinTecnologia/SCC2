using SUACC.Dominio.Interfaces.Repositorio.Comum;
using SUACC.Infra.Contexto.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using DapperExtensions;
using SUACC.Infra.Contexto.Mapeamento;

namespace SUACC.Infra.Repositorio.Dapper.Comum
{
    public class Repositorio<TEntity> : IServico<TEntity>, IDisposable where TEntity : class
    {
        public IDbConnection Conn { get; set; }

        public Repositorio(IDapperContexto context)
        {
            Conn = context.Connection;
            InicializaMapperDapper();
        }

        public static void InicializaMapperDapper()
        {
            DapperExtensions.DapperExtensions.SetMappingAssemblies(new[] {typeof(AplicacaoMapper).Assembly});
            DapperExtensions.DapperExtensions.SetMappingAssemblies(new[] {typeof(UsuarioCampanhaMapper).Assembly});
            DapperExtensions.DapperExtensions.SetMappingAssemblies(new[] {typeof(AtendimentoMapper).Assembly});
        }

        public dynamic Adicionar(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            return entity == null ? null : Conn.Insert(entity, transaction, commandTimeout);
        }

        public bool Atualizar(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            return entity != null && Conn.Update(entity, transaction, commandTimeout);
        }

        public bool Deletar(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            return entity != null && Conn.Delete(entity, transaction, commandTimeout);
        }

        public TEntity ObterPorId(int id, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            return Conn.Get<TEntity>(id, transaction, commandTimeout);
        }

        public IEnumerable<TEntity> ObterTodos(IDbTransaction transaction = null, int? commandTimeout = null)
        {
            return Conn.GetList<TEntity>(null, null, transaction, commandTimeout);
        }

        public IEnumerable<TEntity> ObterPor(object @where = null, object order = null, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            return Conn.GetList<TEntity>(@where);
        }

        public IEnumerable<TEntity> ObterPorProcedimento(string nomeProcedimento, DynamicParameters parametros)
        {
            return Conn.Query<TEntity>(nomeProcedimento, parametros, commandType: CommandType.StoredProcedure).ToList();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
