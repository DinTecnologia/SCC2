using System;
using System.Collections.Generic;
using SUACC.Aplicacao.Interfaces;
using SUACC.Aplicacao.ViewModel;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Validacoes;
using SUACC.Infra.Contexto.Interfaces;

namespace SUACC.Aplicacao
{
    public class AplicacaoAppServico : AppServico, IAplicacaoAppServico
    {
        private readonly IAplicacaoServico _servico;
        private readonly IUnitOfWork _uow;

        public AplicacaoAppServico(IAplicacaoServico servico, IUnitOfWork uow)
        {
            _servico = servico;
            _uow = uow;
        }

        public ValidationResult Adicionar(Dominio.Entidades.Aplicacao entity)
        {
            ValidationResult.Add(_servico.Adicionar(entity, _uow.BeginTransaction()));
            if (ValidationResult.IsValid) _uow.Commit();
            return ValidationResult;
        }

        public ValidationResult Adicionar(AplicacaoAddViewModel viewModel)
        {
            var entidade = new Dominio.Entidades.Aplicacao(viewModel.Nome, viewModel.Url, viewModel.Ssl, viewModel.CriadoPor, null, true);

            ValidationResult.Add(_servico.Adicionar(entidade, _uow.BeginTransaction()));
            if (ValidationResult.IsValid) _uow.Commit();
            return ValidationResult;
        }

        public ValidationResult Atualizar(Dominio.Entidades.Aplicacao entity)
        {
            ValidationResult.Add(_servico.Atualizar(entity, _uow.BeginTransaction()));
            if (ValidationResult.IsValid) _uow.Commit();
            return ValidationResult;
        }

        public ValidationResult Deletar(Dominio.Entidades.Aplicacao entity)
        {
            ValidationResult.Add(_servico.Deletar(entity, _uow.BeginTransaction()));
            if (ValidationResult.IsValid) _uow.Commit();
            return ValidationResult;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<AplicacaoListaViewModel> Obter()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dominio.Entidades.Aplicacao> ObterPor(object where = null, object order = null)
        {
            return _servico.ObterPor(@where);
        }

        public Dominio.Entidades.Aplicacao ObterPorId(int id)
        {
            return _servico.ObterPorId(id);
        }

        public IEnumerable<Dominio.Entidades.Aplicacao> ObterTodos()
        {
            return _servico.ObterTodos();
        }
    }
}
