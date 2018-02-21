using SUACC.Dominio.Interfaces.Especificacoes;

namespace SUACC.Dominio.Entidades.Especificacao.Atividades
{
    public class AtividadeCanalIdNaoPodeSerZeroEspecificacao : ISpecification<Atividade>
    {
        public bool IsSatisfiedBy(Atividade entidade)
        {
            return entidade.CanalId > 0;
        }
    }
}
