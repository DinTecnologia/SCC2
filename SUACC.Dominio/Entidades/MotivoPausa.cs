using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;

namespace SUACC.Dominio.Entidades
{
    
    
    public class MotivoPausa
    {

        public MotivoPausa()
        {
                ValidationResult = new ValidationResult();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int? TempoEstimado { get; set; }
        public bool PadraoFerramenta { get; set; }
        public DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }


    }
}
