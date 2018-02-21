using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Servicos.Comum;

namespace SUACC.Dominio.Interfaces.Servicos
{    
    public interface IClassificacaoServico : IServico<Classificacao>
    {
        Classificacao ObterClassificacaoPadraoLigacao();

    }
}
