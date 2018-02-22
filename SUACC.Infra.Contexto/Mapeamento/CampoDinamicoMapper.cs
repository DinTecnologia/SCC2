using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class CampoDinamicoMapper : ClassMapper<CampoDinamico>
    {
        public CampoDinamicoMapper()
        {
            Table("CampoDinamicos");
            Map(p => p.Id).Column("Id");
            Map(p => p.Nome).Column("Nome");
            Map(p => p.Tipo).Column("Nome");
            Map(p => p.Obrigatorio).Column("Nome");
            Map(p => p.Script).Column("Nome");
            Map(p => p.Atributos).Column("Nome");
            Map(p => p.CssProprio).Column("Nome");
            Map(p => p.PadraoFerramenta).Column("Nome");
            Map(p => p.CriadoEm).Column("Nome");
            Map(p => p.CriadoPor).Column("Nome");
            Map(p => p.AtualizadoEm).Column("Nome");
            Map(p => p.AtualizadoPor).Column("Nome");
            Map(p => p.Ativo).Column("Nome");
        }
    }
}
