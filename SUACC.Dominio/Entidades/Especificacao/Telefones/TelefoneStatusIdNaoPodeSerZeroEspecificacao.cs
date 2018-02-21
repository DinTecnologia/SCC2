using SUACC.Dominio.Interfaces.Especificacoes;

namespace SUACC.Dominio.Entidades.Especificacao.Telefones
{
    public class TelefoneStatusIdNaoPodeSerZeroEspecificacao : ISpecification<Telefone>
    {
        public bool IsSatisfiedBy(Telefone entidade)
        {
            return entidade.StatusEntidadeCampoValoresId > 0;
        }
    }
}