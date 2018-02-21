using System;
using AutoMapper;
using SUACC.Aplicacao.Interfaces;
using SUACC.Aplicacao.ViewModel;
using SUACC.Dominio.Entidades;
using SUACC.Dominio.Entidades.ValuesObject;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Validacoes;
using SUACC.Infra.Contexto.Interfaces;

namespace SUACC.Aplicacao
{
    public class AtendimentoAppServico : AppServico, IAtendimentoAppServico
    {
        private readonly IAtendimentoServico _atendimentoServico;
        private readonly ILigacaoServico _ligacaoServico;
        private readonly ITelefoneServico _telefoneServico;
        private readonly IUnitOfWork _uow;

        public AtendimentoAppServico(IAtendimentoServico atendimentoServico, IUnitOfWork uow,
            ILigacaoServico ligacaoServico, ITelefoneServico telefoneServico)
        {
            _atendimentoServico = atendimentoServico;
            _uow = uow;
            _ligacaoServico = ligacaoServico;
            _telefoneServico = telefoneServico;
        }

        public AtendimentoCadastroViewModel Adicionar(AtendimentoCadastroViewModel atendimentoCadastroViewModel)
        {
            var atendimento = Mapper.Map<AtendimentoCadastroViewModel, Atendimento>(atendimentoCadastroViewModel);
            var telefone = Mapper.Map<AtendimentoCadastroViewModel, Telefone>(atendimentoCadastroViewModel);
            atendimento.Telefones.Add(telefone);

            ValidationResult.Add(_atendimentoServico.Adicionar(atendimento, _uow.BeginTransaction()));
            if (ValidationResult.IsValid) _uow.Commit();
            atendimentoCadastroViewModel = Mapper.Map<Atendimento, AtendimentoCadastroViewModel>(atendimento);
            return atendimentoCadastroViewModel;
        }

        public AtendimentoCadastroViewModel NovaLigacaoReceptiva(AtendimentoCadastroViewModel model)
        {
            try
            {
                if (model.NumeroTelefone <= 0)
                {
                    model.ValidationResult.Add(new ValidationError("Nenhum Telefone Informado"));
                    return model;
                }

                var atendimento = _atendimentoServico.GerarEntidade(model.UsuarioId, (int) CanalEnum.Telefonico, null,
                    model.CampanhaId);

                ValidationResult.Add(_atendimentoServico.Adicionar(atendimento, _uow.BeginTransaction()));
                if (ValidationResult.IsValid) _uow.Commit();
                else
                {
                    model.ValidationResult = ValidationResult;
                    return model;
                }

                var telefone = new Telefone(atendimento.Id, model.ClienteId, (int) StatusTelefoneEnum.Ativo,
                    (int) TipoTelefoneEnum.Indefinido, null, null, model.NumeroTelefone, model.UsuarioId);

                ValidationResult.Add(_telefoneServico.Adicionar(telefone, _uow.BeginTransaction()));
                if (ValidationResult.IsValid) _uow.Commit();
                else
                {
                    model.ValidationResult = ValidationResult;
                    return model;
                }


                var ligacao = _ligacaoServico.AdicionarReceptivo(model.UsuarioId, telefone.Id, atendimento.Id,
                    model.CampanhaId);

                if (ligacao.ValidationResult.IsValid)
                    return new AtendimentoCadastroViewModel(atendimento.Id, atendimento.Protocolo, ligacao.Id, null);

                model.ValidationResult = ligacao.ValidationResult;
                return model;
            }
            catch (Exception ex)
            {
                _uow.Rollback();
                return model;
            }
        }
    }
}
