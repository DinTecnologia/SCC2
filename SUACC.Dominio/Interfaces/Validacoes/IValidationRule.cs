namespace SUACC.Dominio.Interfaces.Validacoes
{
    public interface IValidationRule<in TEntity>
    {
        string ErrorMessage { get; }
        bool Valid(TEntity entity);
    }
}
