using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;

namespace SUACC.Dominio.Entidades
{
    public class CampoDinamicoOpcao
    {
        public long Id { get; set; }
        public string CampoDinamicoId { get; set; }
        public string Nome { get; set; }
        public bool Selecionado { get; set; }
        public DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }
    }
}
