using SUACC.Dominio.Interfaces.Especificacoes;

namespace SUACC.Dominio.Entidades.Especificacao.Atividades
{
    public class AtividadeClassificacaoIdNaoPodeSerNuloOuEmBrancoEspecificacao : ISpecification<Atividade>
    {
        public bool IsSatisfiedBy(Atividade entidade)
        {
            return !string.IsNullOrEmpty(entidade.ClassificacaoId) &&
                   !string.IsNullOrWhiteSpace(entidade.ClassificacaoId);
        }
    }
}
