using System;
using SUACC.Dominio.Entidades.Validacao.Ligacoes;
using SUACC.Dominio.Entidades.ValuesObject;
using SUACC.Dominio.Validacoes;

namespace SUACC.Dominio.Entidades
{
    public class Ligacao : Atividade
    {
        public Ligacao()
        {
            Id = Guid.NewGuid().ToString();
            AtividadeTipoId = (int) AtividadeTipoEnum.Ligacao;
            CriadoEm = DateTime.Now;
            ValidationResult = new ValidationResult();
            CanalId = (int) CanalEnum.Telefonico;
        }

        public string AtividadeId { get; set; }
        public string TelefoneId { get; set; }
        public int TotalTentativaCliente { get; set; }
        public int TotalTentativaTelefone { get; set; }
        public string Direcao { get; set; }

        public void SetLigacaoAtiva()
        {
            Direcao = "S";
        }
        public void SetLigacaoReceptiva()
        {
            Direcao = "E";
        }

        /// <summary>
        /// Retorno da Validação
        /// </summary>
        public override bool IsValid
        {
            get
            {
                if (!base.IsValid)
                    return false;

                ValidationResult = new LigacaoEstaConsistenteValidacao().Valid(this);
                return ValidationResult.IsValid;
            }
        }
    }
}
