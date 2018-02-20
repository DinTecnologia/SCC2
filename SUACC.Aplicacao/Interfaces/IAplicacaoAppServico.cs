using SUACC.Aplicacao.ViewModel;
using SUACC.Dominio.Validacoes;
using System.Collections.Generic;

namespace SUACC.Aplicacao.Interfaces
{
    public interface IAplicacaoAppServico : IAppServico<SUACC.Dominio.Entidades.Aplicacao>
    {
        ValidationResult Adicionar(AplicacaoAddViewModel viewModel);
        IEnumerable<AplicacaoListaViewModel> Obter();
    }
}
