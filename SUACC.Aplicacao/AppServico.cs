using SUACC.Dominio.Validacoes;
using SUACC.Infra.Contexto.Interfaces;

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
