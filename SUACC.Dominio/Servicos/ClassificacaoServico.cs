using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Servicos.Comum;

namespace SUACC.Dominio.Servicos
{
    public class ClassificacaoServico : Servico<Classificacao>, IClassificacaoServico
    {
        public ClassificacaoServico(IClassificacaoRepositorio repositorio) : base(repositorio)
        {

        }

        public Classificacao ObterClassificacaoPadraoLigacao()
        {
            throw new System.NotImplementedException();
        }
    }
}
