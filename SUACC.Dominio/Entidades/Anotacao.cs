using SUACC.Dominio.Validacoes;
using System;

namespace SUACC.Dominio.Entidades
{
    public partial class Anotacao
    {
        public string Id { get; set; }
        public long Identidade { get; set; }
        public string Descricao { get; set; }
        public string OcorrenciaId { get; set; }
        public string AtividadeId { get; set; }
        public string ClienteId { get; set; }
        public DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }

        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Atividade Atividade { get; set; }
        public virtual Ocorrencia Ocorrencia { get; set; }
    }
}
