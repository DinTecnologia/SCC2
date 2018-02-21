using SUACC.Dominio.Interfaces.Especificacoes;

namespace SUACC.Dominio.Entidades.Especificacao.Atendimentos
{
    public class AtendimentoCanalIdNaoPodeSerZeroEspecificacao : ISpecification<Atendimento>
    {
        public bool IsSatisfiedBy(Atendimento entidade)
        {
            return entidade.CanalId > 0;
        }
    }
}