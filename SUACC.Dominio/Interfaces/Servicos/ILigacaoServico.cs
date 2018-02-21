using System.Data;
using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Servicos.Comum;

namespace SUACC.Dominio.Interfaces.Servicos
{
    public interface ILigacaoServico : IServico<Ligacao>
    {
        //Ligacao AdicionarReceptivo(string usuarioId, string numeroTelefone, string informacaoUra, string codigoLigacao,
        //    string ramalOperador, string atendimentoId, long? campanhaId, IDbTransaction transaction = null);

        //Ligacao AdicionarReceptivo(string usuarioId, string telefoneId, string atendimentoId, long? campanhaId,
        //    IDbTransaction transaction = null);

        Ligacao AdicionarReceptivo(string usuarioId, string telefoneId, string atendimentoId, long? campanhaId);
    }
}
