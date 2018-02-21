using SUACC.Dominio.Entidades.Especificacao.Atividades;
using SUACC.Dominio.Validacoes;

namespace SUACC.Dominio.Entidades.Validacao.Atividades
{
    public class AtividadeEstaConsistenteValidacao : Validation<Atividade>
    {
        public AtividadeEstaConsistenteValidacao()
        {
            AddRule(new ValidationRule<Atividade>(new AtividadeCanalIdNaoPodeSerZeroEspecificacao(),
                "O Canal não pode ser vazio ou nulo."));
            AddRule(new ValidationRule<Atividade>(new AtividadeClassificacaoIdNaoPodeSerNuloOuEmBrancoEspecificacao(),
                "A Classificação não pode ser vazia ou nula."));
            AddRule(new ValidationRule<Atividade>(new AtividadeTipoIdNaoPodeSerZeroEspecificacao(),
                "O Tipo da atividade não pode ser zero"));
        }
    }
}



