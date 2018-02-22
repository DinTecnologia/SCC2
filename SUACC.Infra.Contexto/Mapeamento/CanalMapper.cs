using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class CanalMapper : ClassMapper<Canal>
    {
        public CanalMapper()
        {
            Table("Canais");
            Map(p => p.Id).Column("Id").Key(KeyType.Identity);
            Map(p => p.Nome).Column("Nome");
            Map(p => p.Descricao).Column("Nome");
            Map(p => p.CriadoEm).Column("Nome");
            Map(p => p.CriadoPor).Column("Nome");
            Map(p => p.AtualizadoEm).Column("Nome");
            Map(p => p.AtualizadoPor).Column("Nome");
            Map(p => p.Ativo).Column("Nome");
        }
    }
}
