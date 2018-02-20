using SUACC.Dominio.Validacoes;

namespace SUACC.Dominio.Interfaces.Validacoes
{
    public interface ISelfValidation
    {
        ValidationResult ValidationResult { get; }
        bool IsValid { get; }
    }
}
