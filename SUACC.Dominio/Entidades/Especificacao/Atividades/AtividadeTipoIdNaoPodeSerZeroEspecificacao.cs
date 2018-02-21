using SUACC.Dominio.Interfaces.Especificacoes;

namespace SUACC.Dominio.Entidades.Especificacao.Atividades
{
    public class AtividadeTipoIdNaoPodeSerZeroEspecificacao : ISpecification<Atividade>
    {
        public bool IsSatisfiedBy(Atividade entidade)
        {
            return entidade.AtividadeTipoId > 0;
        }
    }
}