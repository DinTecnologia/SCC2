using SUACC.Dominio.Validacoes;
using System;

namespace SUACC.Dominio.Entidades
{
    public partial class Configuracao
    {
        public Configuracao()
        {

        }

        public string Id { get; set; }
        public int Identidade { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public string Valor { get; set; }
        public bool PadraoFerramenta { get; set; }
        public DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public string AtualizadoPor { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }
    }
}
