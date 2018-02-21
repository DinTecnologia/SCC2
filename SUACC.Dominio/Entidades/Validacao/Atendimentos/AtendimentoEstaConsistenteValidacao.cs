using SUACC.Dominio.Entidades.Especificacao.Atendimentos;
using SUACC.Dominio.Validacoes;

namespace SUACC.Dominio.Entidades.Validacao.Atendimentos
{
    public class AtendimentoEstaConsistenteValidacao : Validation<Atendimento>
    {
        public AtendimentoEstaConsistenteValidacao()
        {
            AddRule(new ValidationRule<Atendimento>(new AtendimentoCanalIdNaoPodeSerZeroEspecificacao(),
                "O Canal do Atendimento não pode ser zero."));

            AddRule(new ValidationRule<Atendimento>(new AtendimentoCriadoPorNaoPodeSerNuloOuEmBrancoEspecificacao(),
                "O usuário criador é obrigatório."));
        }
    }
}