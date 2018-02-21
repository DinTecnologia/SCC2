using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;

namespace SUACC.Dominio.Entidades
{   
    public partial class Atividade
    {        
        public Atividade()
        {
            Anotacoes = new HashSet<Anotacao>();
            AtendimentoInteracoes = new HashSet<AtendimentoInteracao>();
            Emails = new HashSet<Email>();
            FilaAtividades = new HashSet<FilaAtividade>();
            Ligacoes = new HashSet<Ligacao>();
            Tarefas = new HashSet<Tarefa>();
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
        public Nullable<System.DateTime> PrevisaoAtendimento { get; set; }
        public Nullable<System.DateTime> PrevisaoFinalizar { get; set; }
        public Nullable<System.DateTime> IniciadoEm { get; set; }
        public string IniciadoPor { get; set; }
        public Nullable<System.DateTime> FinalizadoEm { get; set; }
        public string FinalizadoPor { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }


        public virtual ICollection<Anotacao> Anotacoes { get; set; }
        public virtual ICollection<AtendimentoInteracao> AtendimentoInteracoes { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<FilaAtividade> FilaAtividades { get; set; }
        public virtual ICollection<Ligacao> Ligacoes { get; set; }
        public virtual ICollection<Tarefa> Tarefas { get; set; }
    }
}
