using SUACC.Aplicacao.ViewModel;

namespace SUACC.Aplicacao.Interfaces
{
    public interface IAtendimentoAppServico
    {
        AtendimentoCadastroViewModel Adicionar(AtendimentoCadastroViewModel atendimentoCadastroViewModel);
        AtendimentoCadastroViewModel NovaLigacaoReceptiva(AtendimentoCadastroViewModel atendimentoCadastroViewModel);
    }
}
