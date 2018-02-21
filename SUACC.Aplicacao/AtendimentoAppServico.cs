using AutoMapper;
using SUACC.Aplicacao.Interfaces;
using SUACC.Aplicacao.ViewModel;
using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Infra.Contexto.Interfaces;

namespace SUACC.Aplicacao
{
    public class AtendimentoAppServico : AppServico, IAtendimentoAppServico
    {
        private readonly IAtendimentoServico _atendimentoServico;
        private readonly IUnitOfWork _uow;

        public AtendimentoAppServico(IAtendimentoServico atendimentoServico, IUnitOfWork uow)
        {
            _atendimentoServico = atendimentoServico;
            _uow = uow;
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
    }
}
