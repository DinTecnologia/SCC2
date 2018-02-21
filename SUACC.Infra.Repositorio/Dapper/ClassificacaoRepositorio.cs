using System.Collections.Generic;
using Dapper;
using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Infra.Contexto.Interfaces;
using SUACC.Infra.Repositorio.Dapper.Comum;

namespace SUACC.Infra.Repositorio.Dapper
{
    public class ClassificacaoRepositorio : Repositorio<Classificacao>, IClassificacaoRepositorio
    {
        public ClassificacaoRepositorio(IDapperContexto context)
             : base(context)
        {

        }

        public IEnumerable<Classificacao> ObterComum(string id, string nome, string entidadeIds, string atividadeTipoIds,
           string entidadeIdsPadrao,
           string atividadeTipoIdsPadrao, string direcao, bool? finalizadora, bool? padraoFerramenta)
        {
            var parametros = new DynamicParameters();

            parametros.Add("Id", string.IsNullOrEmpty(id) ? null : id);
            parametros.Add("Nome", string.IsNullOrEmpty(nome) ? null : id);
            parametros.Add("EntidadeIds", string.IsNullOrEmpty(entidadeIds) ? null : id);
            parametros.Add("AtividadeTipoIds", string.IsNullOrEmpty(atividadeTipoIds) ? null : id);
            parametros.Add("EntidadeIdsPadrao", string.IsNullOrEmpty(entidadeIdsPadrao) ? null : id);
            parametros.Add("AtividadeTipoIdsPadrao", string.IsNullOrEmpty(atividadeTipoIdsPadrao) ? null : id);
            parametros.Add("Direcao", string.IsNullOrEmpty(direcao) ? null : id);
            parametros.Add("Finalizadora", finalizadora);
            parametros.Add("PadraoFerramenta", padraoFerramenta);

            return ObterPorProcedimento("sp_Configuracoes_SEL", parametros);
        }
    }
}
