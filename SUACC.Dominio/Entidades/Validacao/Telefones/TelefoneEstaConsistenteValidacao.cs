using SUACC.Dominio.Entidades.Especificacao.Telefones;
using SUACC.Dominio.Validacoes;

namespace SUACC.Dominio.Entidades.Validacao.Telefones
{
    public class TelefoneEstaConsistenteValidacao : Validation<Telefone>
    {
        public TelefoneEstaConsistenteValidacao()
        {
            AddRule(new ValidationRule<Telefone>(new TelefoneStatusIdNaoPodeSerZeroEspecificacao(),
                "O Status do Telefone não pode ser zero."));
            AddRule(new ValidationRule<Telefone>(new TelefoneTipoIdNaoPodeSerZeroEspecificacao(),
                "O Tipo do Telefone não pode ser zero."));
        }
    }
}