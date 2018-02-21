using SUACC.Dominio.Interfaces.Especificacoes;

namespace SUACC.Dominio.Entidades.Especificacao.Ligacoes
{
    public class LigacaoCanalNaoPodeSerNuloEspecificacao : ISpecification<Ligacao>
    {
        public bool IsSatisfiedBy(Ligacao entidade)
        {
            return entidade.CanalId != 0;
        }
    }
}

