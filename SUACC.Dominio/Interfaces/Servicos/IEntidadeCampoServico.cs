using System.Collections.Generic;
using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Servicos.Comum;

namespace SUACC.Dominio.Interfaces.Servicos
{   
    public interface IEntidadeCampoValorServico : IServico<EntidadeCampoValor>
    {
        IEnumerable<EntidadeCampoValor> ObterPor(int? entidadeId, string nomeCampo, bool? padrao);
    }
}
