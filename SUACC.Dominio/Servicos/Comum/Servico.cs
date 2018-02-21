using SUACC.Dominio.Interfaces.Validacoes;
using SUACC.Dominio.Validacoes;
using System.Collections.Generic;
using System.Data;

namespace SUACC.Dominio.Servicos.Comum
{
    public class Servico<TEntity> : Interfaces.Servicos.Comum.IServico<TEntity> where TEntity : class
    {
        private readonly Interfaces.Repositorio.Comum.IServico<TEntity> _repositorio;
        private readonly ValidationResult _validationResult;

        public Servico(Interfaces.Repositorio.Comum.IServico<TEntity> repositorio)
        {
            _repositorio = repositorio;
            _validationResult = new ValidationResult();
        }

        protected ValidationResult ValidationResult
        {
            get { return _validationResult; }
        }

        public virtual ValidationResult Adicionar(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = default(int?))
        {
            if (!_validationResult.IsValid)
                return ValidationResult;

            var selfValidationEntity = entity as ISelfValidation;
            if (selfValidationEntity != null && !selfValidationEntity.IsValid)
                return selfValidationEntity.ValidationResult;

            var adicionou = _repositorio.Adicionar(entity, transaction);
            if (adicionou == null)
                _validationResult.Add("A Entidade que você está tentando gravar está nula, por favor tente novamente!" + entity + " Método-> Adicionar");
            return _validationResult;
        }

        public virtual ValidationResult Atualizar(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = default(int?))
        {
            if (!ValidationResult.IsValid)
                return ValidationResult;

            var selfValidationEntity = entity as ISelfValidation;
            if (selfValidationEntity != null && !selfValidationEntity.IsValid)
                return selfValidationEntity.ValidationResult;

            var atualizar = _repositorio.Atualizar(entity);
            if (!atualizar)
                _validationResult.Add("A Entidade que você está tentando atualizar está nula, por favor tente novamente! Nome: " + entity + "Atualizar");
            return _validationResult;
        }

        public virtual ValidationResult Deletar(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = default(int?))
        {
            if (!ValidationResult.IsValid)
                return ValidationResult;

            var deletou = _repositorio.Deletar(entity);
            if (!deletou)
                _validationResult.Add("A Entidade que você está tentando deletar está nula, por favor tente novamente! Nome: " + entity + "Deletar");
            return _validationResult;
        }

        public virtual TEntity ObterPorId(int id, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            return _repositorio.ObterPorId(id);
        }

        public virtual IEnumerable<TEntity> ObterTodos(IDbTransaction transaction = null, int? commandTimeout = null)
        {
            return _repositorio.ObterTodos();
        }

        public virtual IEnumerable<TEntity> ObterPor(object @where = null, object order = null, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            return _repositorio.ObterPor(@where);
        }
    }
}
