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
    
    public partial class Campanha
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Campanha()
        {
            this.Filas = new HashSet<Fila>();
        }
    
        public string Id { get; set; }
        public long Identidade { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public System.DateTime IniciaEm { get; set; }
        public System.DateTime FinalizaEm { get; set; }
        public string AtividadeTipoIds { get; set; }
        public string CanalTiposIds { get; set; }
        public bool PadraoFerramenta { get; set; }
        public System.DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public Nullable<System.DateTime> AtualizadoEm { get; set; }
        public string AtualizadoPor { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fila> Filas { get; set; }
    }
}
