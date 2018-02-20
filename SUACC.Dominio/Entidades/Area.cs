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
    
    public partial class Area
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Area()
        {
            this.Menus = new HashSet<Menu>();
        }
    
        public string Id { get; set; }
        public short Identidade { get; set; }
        public string AplicacaoId { get; set; }
        public string Nome { get; set; }
        public string Namespace { get; set; }
        public string CriadoPor { get; set; }
        public System.DateTime CriadoEm { get; set; }
        public string AtualizadoPor { get; set; }
        public Nullable<System.DateTime> AtualizadoEm { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }

        public virtual Anotacao Aplicacao { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }
    }
}