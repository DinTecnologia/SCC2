using SUACC.Dominio.Entidades.Especificacao.Aplicacaoes;
using SUACC.Dominio.Validacoes;

namespace SUACC.Dominio.Entidades.Validacao.Aplicacaoes
{
    public class AplicacaoEstaConsistenteValidation : Validation<Aplicacao>
    {
        public AplicacaoEstaConsistenteValidation()
        {
            AddRule(new ValidationRule<Aplicacao>(new AplicacaoNomeNaoPodeSerNuloOuEmBrancoSpecification(), "O Nome da Aplicação não pode ser nula ou em branco."));
        }
    }
}
