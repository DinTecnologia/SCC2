using System.Collections.Generic;
using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio.Comum;

namespace SUACC.Dominio.Interfaces.Repositorio
{    
    public interface IClassificacaoRepositorio : IServico<Classificacao>
    {
        IEnumerable<Classificacao> ObterComum(string id, string nome, string entidadeIds, string atividadeTipoIds,
             string entidadeIdsPadrao, string atividadeTipoIdsPadrao, string direcao, bool? finalizadora,
             bool? padraoFerramenta);
    }
}
