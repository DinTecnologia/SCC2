using SUACC.Dominio.Interfaces.Especificacoes;

namespace SUACC.Dominio.Entidades.Especificacao.Telefones
{
    public class TelefoneTipoIdNaoPodeSerZeroEspecificacao : ISpecification<Telefone>
    {
        public bool IsSatisfiedBy(Telefone entidade)
        {
            return entidade.TipoEntidadeCampoValoresId > 0;
        }
    }
}
