using SUACC.Dominio.Interfaces.Especificacoes;

namespace SUACC.Dominio.Entidades.Especificacao.Aplicacoes
{
    public class AplicacaoNomeNaoPodeSerNuloOuEmBrancoSpecification : ISpecification<Aplicacao>
    {
        public bool IsSatisfiedBy(Aplicacao entidade)
        {
            return !string.IsNullOrEmpty(entidade.Nome) && !string.IsNullOrWhiteSpace(entidade.Nome);
        }
    }
}
