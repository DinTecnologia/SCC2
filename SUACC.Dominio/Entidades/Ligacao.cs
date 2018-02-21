using System;

namespace SUACC.Dominio.Entidades
{
    public partial class Ligacao : Atividade
    {
        public Ligacao()
        {
            Id = Guid.NewGuid().ToString();
            AtividadeTipoId = (int)AtividadeTipo.Ligacao;
            CriadoEm = DateTime.Now;
        }


        //public string Id { get; set; }
        //public long Identidade { get; set; }
        public string AtividadeId { get; set; }
        //public string ClienteId { get; set; }
        public string TelefoneId { get; set; }
        public int TotalTentativaCliente { get; set; }
        public int TotalTentativaTelefone { get; set; }
        //public System.DateTime CriadoEm { get; set; }
        //public string CriadoPor { get; set; }
        // public ValidationResult ValidationResult { get; private set; }


        //public virtual AspNetUser AspNetUser { get; set; }
        //public virtual Atividade Atividade { get; set; }
        //public virtual Cliente Cliente { get; set; }
        //public virtual Telefone Telefone { get; set; }
    }
}
