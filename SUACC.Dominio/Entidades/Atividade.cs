using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;
using SUACC.Dominio.Entidades.Validacao.Atividades;

namespace SUACC.Dominio.Entidades
{
    public class Atividade
    {
        public Atividade()
        {
            Anotacoes = new HashSet<Anotacao>();
            AtendimentoInteracoes = new HashSet<AtendimentoInteracao>();
            Emails = new HashSet<Email>();
            FilaAtividades = new HashSet<FilaAtividade>();
            Ligacoes = new HashSet<Ligacao>();
            Tarefas = new HashSet<Tarefa>();
            ValidationResult = new ValidationResult();
            Id = Guid.NewGuid().ToString();
            CriadoEm = DateTime.Now;
        }

        public string Id { get; set; }
        public long Identidade { get; set; }
        public int AtividadeTipoId { get; set; }
        public int CanalId { get; set; }
        public string ClassificacaoId { get; set; }
        public string ClienteId { get; set; }
        public string OcorrenciaId { get; set; }
        public string AtendimentoId { get; set; }
        public string AtividadeDeOrigemId { get; set; }
        public DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public DateTime? PrevisaoAtendimento { get; set; }
        public DateTime? PrevisaoFinalizar { get; set; }
        public DateTime? IniciadoEm { get; set; }
        public string IniciadoPor { get; set; }
        public DateTime? FinalizadoEm { get; set; }
        public string FinalizadoPor { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; set; }

        public virtual ICollection<Anotacao> Anotacoes { get; set; }
        public virtual ICollection<AtendimentoInteracao> AtendimentoInteracoes { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<FilaAtividade> FilaAtividades { get; set; }
        public virtual ICollection<Ligacao> Ligacoes { get; set; }
        public virtual ICollection<Tarefa> Tarefas { get; set; }
        
        public virtual bool IsValid
        {
            get
            {
                ValidationResult = new AtividadeEstaConsistenteValidacao().Valid(this);
                return ValidationResult.IsValid;
            }
        }
    }
}
