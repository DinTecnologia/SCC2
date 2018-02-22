using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class CampanhaMapper : ClassMapper<Campanha>
    {
        public CampanhaMapper()
        {
            Table("Campanhas");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.Nome).Column("Nome");
            Map(p => p.Descricao).Column("Descricao");
            Map(p => p.IniciaEm).Column("IniciaEm");
            Map(p => p.FinalizaEm).Column("FinalizaEm");
            Map(p => p.AtividadeTipoIds).Column("AtividadeTipoIds");
            Map(p => p.CanalTiposIds).Column("CanalTiposIds");
            Map(p => p.PadraoFerramenta).Column("PadraoFerramenta");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.AtualizadoEm).Column("AtualizadoEm");
            Map(p => p.AtualizadoPor).Column("AtualizadoPor");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
