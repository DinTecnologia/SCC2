using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;

namespace SUACC.Dominio.Entidades
{

    public partial class EntidadeSecao
    {
        public EntidadeSecao()
        {
            EntidadeSecaoAbas = new HashSet<EntidadeSecaoAba>();
        }

        public string Id { get; set; }
        public int Identidade { get; set; }
        public string EntidadeId { get; set; }
        public string Nome { get; set; }
        public int Ordem { get; set; }
        public string Script { get; set; }
        public bool PadraoFerramenta { get; set; }
        public DateTime? CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public string AtualizadoPor { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }

        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual Entidade Entidade { get; set; }
        public virtual ICollection<EntidadeSecaoAba> EntidadeSecaoAbas { get; set; }
    }
}
