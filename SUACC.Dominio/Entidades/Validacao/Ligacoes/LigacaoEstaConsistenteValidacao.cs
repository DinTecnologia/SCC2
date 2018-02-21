using SUACC.Dominio.Entidades.Especificacao.Ligacoes;
using SUACC.Dominio.Validacoes;

namespace SUACC.Dominio.Entidades.Validacao.Ligacoes
{
    public class LigacaoEstaConsistenteValidacao : Validation<Ligacao>
    {
        public LigacaoEstaConsistenteValidacao()
        {
            //AddRule(new ValidationRule<Ligacao>(new LigacaoCanalNaoPodeSerNuloEspecificacao(), "O Nome da Aplicação não pode ser nula ou em branco."));
        }
    }
}