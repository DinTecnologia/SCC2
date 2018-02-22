using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{   
    public  class FuncionalidadeMapper : ClassMapper<Funcionalidade>
    {
        public FuncionalidadeMapper()
        {
            Table("Funcionalidades");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.Nome).Column("Nome");
            Map(p => p.ControllerName).Column("ControllerName");
            Map(p => p.ActionName).Column("ActionName");
            Map(p => p.Parametros).Column("Parametros");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.AtualizadoPor).Column("AtualizadoPor");
            Map(p => p.AtualizadoEm).Column("AtualizadoEm");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
