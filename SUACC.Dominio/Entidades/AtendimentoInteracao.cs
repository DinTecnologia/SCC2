using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;

namespace SUACC.Dominio.Entidades
{   
    public partial class AtendimentoInteracao
    {
        public long Id { get; set; }
        public string AtendimentoId { get; set; }
        public string AtividadeId { get; set; }
        public string OcorrenciaId { get; set; }
        public DateTime CriadoEm { get; set; }
        public ValidationResult ValidationResult { get; private set; }


        public virtual Atendimento Atendimento { get; set; }
        public virtual Atividade Atividade { get; set; }
        public virtual Ocorrencia Ocorrencia { get; set; }
    }
}
