using SUACC.Dominio.Validacoes;

namespace SUACC.Dominio.Entidades
{
    public class AtividadeTipo
    {
        public AtividadeTipo()
        {
            ValidationResult = new ValidationResult();
        }

        public string Id { get; set; }
        public int Identidade { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public System.DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public bool PadraoFerramenta { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }

    }
}
