using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;

namespace SUACC.Dominio.Entidades
{   
    public class Ocorrencia
    {   
        public Ocorrencia()
        {
            Anotacaoes = new HashSet<Anotacao>();
            AtendimentoInteracoes = new HashSet<AtendimentoInteracao>();
        }
    
        public string Id { get; set; }
        public long Identidade { get; set; }
        public string Protocolo { get; set; }
        public string MotivoId { get; set; }
        public string ClassificacaoId { get; set; }
        public string Descricao { get; set; }
        public string ClienteId { get; set; }
        public string ContratoId { get; set; }
        public string AtendimentoId { get; set; }
        public DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public string AtualizadoPor { get; set; }
        public bool Finalizado { get; set; }
        public bool Ativo { get; set; }
        
        public virtual ICollection<Anotacao> Anotacaoes { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual ICollection<AtendimentoInteracao> AtendimentoInteracoes { get; set; }
        public virtual Atendimento Atendimento { get; set; }
        public virtual Classificacao Classificaco { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Contrato Contrato { get; set; }
        public ValidationResult ValidationResult { get; private set; }
    }
}
