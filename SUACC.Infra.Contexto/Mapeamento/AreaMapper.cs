using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class AreaMapper : ClassMapper<Area>
    {
        public AreaMapper()
        {
            Table("Areas");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.AplicacaoId).Column("AplicacaoId");
            Map(p => p.Nome).Column("Nome");
            Map(p => p.Namespace).Column("Namespace");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.AtualizadoEm).Column("AtualizadoEm");
            Map(p => p.AtualizadoPor).Column("AtualizadoPor");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
