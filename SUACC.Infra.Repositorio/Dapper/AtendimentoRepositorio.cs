using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Infra.Contexto.Interfaces;
using SUACC.Infra.Repositorio.Dapper.Comum;

namespace SUACC.Infra.Repositorio.Dapper
{
    public class AtendimentoRepositorio : Repositorio<Atendimento>, IAtendimentoRepositorio
    {
        public AtendimentoRepositorio(IDapperContexto context)
            : base(context)
        {
        }

        public string ObterNovoProtocolo(int? canalId)
        {
            var parametros = new DynamicParameters();
            parametros.Add("@CanalId", canalId);
            var protocolo = ObterPorProcedimento("sp_Atendimentos_GerarProtocolo_SEL", parametros);
            return protocolo.Any() ? protocolo.FirstOrDefault().Protocolo : null;
        }
    }
}
