using SUACC.Dominio.Validacoes;
using System;

namespace SUACC.Dominio.Entidades
{
    public partial class UsuarioTelefonia
    {
        public string Id { get; set; }
        public long Posicao { get; set; }
        public int Ramal { get; set; }
        public int LoginTelefonia { get; set; }
        public string UsuarioId { get; set; }
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string AtualizadoPor { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }

        public virtual AspNetUser AspNetUser { get; set; }
    }
}
