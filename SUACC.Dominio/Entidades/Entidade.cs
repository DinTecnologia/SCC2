using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;

namespace SUACC.Dominio.Entidades
{   
    public class Entidade
    {
        public Entidade()
        {
            Arquivos = new HashSet<Arquivo>();
            EntidadeCampoValores = new HashSet<EntidadeCampoValor>();
            EntidadeSecoes = new HashSet<EntidadeSecao>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeLogico { get; set; }
        public string Script { get; set; }
        public bool PadraoFerramenta { get; set; }
        public DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public string AtualizadoPor { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }


        
        public virtual ICollection<Arquivo> Arquivos { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual ICollection<EntidadeCampoValor> EntidadeCampoValores { get; set; }
        public virtual ICollection<EntidadeSecao> EntidadeSecoes { get; set; }
    }
}
