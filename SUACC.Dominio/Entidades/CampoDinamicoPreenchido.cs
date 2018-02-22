using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;

namespace SUACC.Dominio.Entidades
{
    public class CampoDinamicoPreenchido
    {
        public string Id { get; set; }
        public long Identidade { get; set; }
        public string ChaveEntidade { get; set; }
        public int CampoDinamicoId { get; set; }
        public string EntidadeSecaoAbaCampoDinamicoId { get; set; }
        public long CampoDinamicoOpcoesId { get; set; }
        public string Valor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }
    }
}
