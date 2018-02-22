using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;

namespace SUACC.Dominio.Entidades
{   
    public  class Remessa
    {

        public Remessa()
        {
            ValidationResult = new ValidationResult();
        }

        public string Id { get; set; }
        public long Identidade { get; set; }
        public string MailingId { get; set; }
        public int StatusEntidadeCampoValoresId { get; set; }
        public int Ordem { get; set; }
        public string NomeArquivo { get; set; }
        public DateTime IniciadoEm { get; set; }
        public DateTime? FinalizadoEm { get; set; }
        public int TotalLinhas { get; set; }
        public string Erro { get; set; }
    
        public virtual EntidadeCampoValor EntidadeCampoValore { get; set; }
        public virtual Mailing Mailing { get; set; }
        public ValidationResult ValidationResult { get; private set; }

    }
}
