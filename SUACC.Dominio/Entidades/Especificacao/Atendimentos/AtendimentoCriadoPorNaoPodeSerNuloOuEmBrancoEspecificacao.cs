using SUACC.Dominio.Interfaces.Especificacoes;

namespace SUACC.Dominio.Entidades.Especificacao.Atendimentos
{
    public class AtendimentoCriadoPorNaoPodeSerNuloOuEmBrancoEspecificacao : ISpecification<Atendimento>
    {
        public bool IsSatisfiedBy(Atendimento entidade)
        {
            return !string.IsNullOrEmpty(entidade.CriadoPor) &&
                   !string.IsNullOrWhiteSpace(entidade.CriadoPor);
        }
    }
}