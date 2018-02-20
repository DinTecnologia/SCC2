using SUACC.Dominio.Validacoes;

namespace SUACC.Aplicacao.ViewModel
{
    public class AplicacaoAddViewModel
    {
        public string Nome { get; set; }
        public string Url { get; set; }
        public bool Ssl { get; set; }
        public ValidationResult Validation { get; set; }
        public string CriadoPor { get; set; }

        public AplicacaoAddViewModel()
        {

        }
    }
}
