using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Servicos.Comum;

namespace SUACC.Dominio.Interfaces.Servicos
{
    public interface IAtendimentoServico : IServico<Atendimento>
    {
        Atendimento GerarEntidade(string usuarioId, int canalId, string protocolo, long? campanhaId);
    }
}
