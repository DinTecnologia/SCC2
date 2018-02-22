using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public  class MenuMapper : ClassMapper<Menu>
    {
        public MenuMapper()
        {
            Table("Menus");
            Map(p => p.Id).Column("Id").Key(KeyType.Identity);
            Map(p => p.Nome).Column("Nome");
            Map(p => p.MenuPaiId).Column("Nome");
            Map(p => p.Tipo).Column("Nome");
            Map(p => p.TipoAbertura).Column("Nome");
            Map(p => p.Ordem).Column("Nome");
            Map(p => p.Icone).Column("Nome");
            Map(p => p.AreaId).Column("Nome");
            Map(p => p.AplicacaoId).Column("Nome");
            Map(p => p.FuncionalidadeId).Column("Nome");
            Map(p => p.CriadoPor).Column("Nome");
            Map(p => p.CriadoEm).Column("Nome");
            Map(p => p.AtualizadoPor).Column("Nome");
            Map(p => p.AtualizadoEm).Column("Nome");
            Map(p => p.Ativo).Column("Nome");
        }
    }
}
