using System.Collections.Generic;
using Dapper;
using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Infra.Contexto.Interfaces;
using SUACC.Infra.Repositorio.Dapper.Comum;


namespace SUACC.Infra.Repositorio.Dapper
{
    public class MenuRepositorio : Repositorio<Menu>, IMenuRepositorio
    {
        public MenuRepositorio(IDapperContexto context)
             : base(context)
        {
        }

        public IEnumerable<Menu> ObterPor(string usuarioId, string url, string aplicacaoId = null)
        {
            var parametros = new DynamicParameters();

            if (!string.IsNullOrEmpty(usuarioId))
                parametros.Add("@usuarioId", usuarioId);

            if (!string.IsNullOrEmpty(url))
                parametros.Add("@aplicacoId", url);

            if (!string.IsNullOrEmpty(aplicacaoId))
                parametros.Add("@url", aplicacaoId);

            return ObterPorProcedimento("sp_Menus_SEL", parametros);
        }
    }
}
