using System.Collections.Generic;
using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Servicos.Comum;

namespace SUACC.Dominio.Servicos
{   
    public class EntidadeCampoValorServico : Servico<EntidadeCampoValor>, IEntidadeCampoValorServico
    {
        public EntidadeCampoValorServico(IEntidadeCampoValorRepositorio repositorio) : base(repositorio)
        {

        }

        public IEnumerable<EntidadeCampoValor> ObterPor(int? entidadeId, string nomeCampo, bool? padrao)
        {
            throw new System.NotImplementedException();
        }
    }
}
