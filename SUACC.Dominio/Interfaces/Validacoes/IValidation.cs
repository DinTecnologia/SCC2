using SUACC.Dominio.Validacoes;

namespace SUACC.Dominio.Interfaces.Validacoes
{
    public interface IValidation<in TEntity>
    {
        ValidationResult Valid(TEntity entity);
    }
}
