using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio.Comum;


namespace SUACC.Dominio.Interfaces.Repositorio
{
    public interface IAtendimentoRepositorio : IServico<Atendimento>
    {
        string ObterNovoProtocolo(int? canalId);
    }
}
