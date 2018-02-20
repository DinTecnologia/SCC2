using SUACC.Dominio.Validacoes;

namespace SUACC.Aplicacao
{
    public class AppServico
    {
        public AppServico()
        {
            ValidationResult = new ValidationResult();
        }
        protected ValidationResult ValidationResult { get; private set; }
    }
}
