using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class UsuarioCampanhaMapper : ClassMapper<UsuarioCampanha>
    {
        public UsuarioCampanhaMapper()
        {
            Table("UsuarioCampanhas");
            Map(p => p.Id).Column("Id");
            Map(p => p.UsuarioId).Column("UsuarioId");
            Map(p => p.CampanhaId).Column("CampanhaId");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.AtualizadoPor).Column("AtualizadoPor");
            Map(p => p.AtualizadoEm).Column("AtualizadoEm");
            Map(p => p.PadraoFerramenta).Column("PadraoFerramenta");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
