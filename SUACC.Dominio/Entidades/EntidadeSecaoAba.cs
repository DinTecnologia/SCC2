//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SUACC.Dominio.Entidades
{
    using SUACC.Dominio.Validacoes;
    using System;
    using System.Collections.Generic;
    
    public partial class EntidadeSecaoAba
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EntidadeSecaoAba()
        {
            this.EntidadeSecaoAbaCampoDinamicos = new HashSet<EntidadeSecaoAbaCampoDinamico>();
        }
    
        public string Id { get; set; }
        public int Identidade { get; set; }
        public string EntidadeSecaoId { get; set; }
        public string Nome { get; set; }
        public int Ordem { get; set; }
        public string Script { get; set; }
        public bool PadraoFerramenta { get; set; }
        public Nullable<System.DateTime> CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public Nullable<System.DateTime> AtualizadoEm { get; set; }
        public string AtualizadoPor { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }


        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntidadeSecaoAbaCampoDinamico> EntidadeSecaoAbaCampoDinamicos { get; set; }
        public virtual EntidadeSecao EntidadeSeco { get; set; }
    }
}