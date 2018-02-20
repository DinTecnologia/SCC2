using SUACC.Dominio.Interfaces.Especificacoes;
using System;

namespace SUACC.Dominio.Entidades.Especificacao.Aplicacaoes
{
    public class AplicacaoNomeNaoPodeSerNuloOuEmBrancoSpecification : ISpecification<Aplicacao>
    {
        public bool IsSatisfiedBy(Aplicacao entidade)
        {
            return !String.IsNullOrEmpty(entidade.Nome) && !String.IsNullOrWhiteSpace(entidade.Nome);
        }
    }
}
