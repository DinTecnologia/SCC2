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
    
    public partial class Mailing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mailing()
        {
            this.Remessas = new HashSet<Remessa>();
        }
    
        public string Id { get; set; }
        public int Identidade { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string NomeArquivo { get; set; }
        public string NomePlanilha { get; set; }
        public string DiretorioLeituraConfiguracaoId { get; set; }
        public string DiretorioProcessamentoConfiguracaoId { get; set; }
        public string DiretorioFinalizadoConfiguracaoId { get; set; }
        public string TipoArquivoEntidadeValorCampoId { get; set; }
        public System.DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public Nullable<System.DateTime> AtualizadoEm { get; set; }
        public string AtualizadoPor { get; set; }
        public ValidationResult ValidationResult { get; private set; }


        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual Configuracao Configuraco { get; set; }
        public virtual Configuracao Configuraco1 { get; set; }
        public virtual Configuracao Configuraco2 { get; set; }
        public virtual EntidadeCampoValor EntidadeCampoValore { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Remessa> Remessas { get; set; }
    }
}
