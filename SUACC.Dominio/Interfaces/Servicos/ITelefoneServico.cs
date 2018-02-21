using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Servicos.Comum;

namespace SUACC.Dominio.Interfaces.Servicos
{
    public interface ITelefoneServico : IServico<Telefone>
    {
        //Telefone GerarEntidade(string atendimentoId, string clienteId, int statusEntidadeCampoValoresId,
        //    int tipoEntidadeCampoValoresId, int? ddi, int? ddd, long numero, string usuarioId);
    }
}
