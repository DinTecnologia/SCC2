using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;

namespace SUACC.Dominio.Entidades
{
    public class Motivo
    {
        public Motivo()
        {
            ValidationResult = new ValidationResult();
        }

        public string Id { get; set; }
        public long Identidade { get; set; }
        public string Nome { get; set; }
        public string MotivoPaiId { get; set; }
        public string NomeExibicao { get; set; }
        public string EstruturaIds { get; set; }
        public string DependenteMotivoId { get; set; }
        public string EntidadesIds { get; set; }
        public string AtividadeTipoIds { get; set; }
        public bool PadraoFerramenta { get; set; }
        public ValidationResult ValidationResult { get; private set; }

    }
}
