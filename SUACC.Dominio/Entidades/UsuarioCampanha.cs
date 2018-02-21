using SUACC.Dominio.Validacoes;
using System;

namespace SUACC.Dominio.Entidades
{
    public class UsuarioCampanha
    {
        public long Id { get; set; }
        public string UsuarioId { get; set; }
        public string CampanhaId { get; set; }
        public bool PadraoFerramenta { get; set; }
        public DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public string AtualizadoPor { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }

        public UsuarioCampanha()
        {
            ValidationResult = new ValidationResult();
        }
    }
}
