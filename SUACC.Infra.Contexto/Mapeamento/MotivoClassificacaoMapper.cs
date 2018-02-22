using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{   
    public  class MotivoClassificacaoMapper : ClassMapper<MotivoClassificacao>
    {
        public MotivoClassificacaoMapper()
        {
            Table("MotivoClassificacoes");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.MotivoId).Column("Nome");
            Map(p => p.ClassificacaoId).Column("Nome");
            Map(p => p.PadraoFerramenta).Column("Nome");
            Map(p => p.CriadoEm).Column("Nome");
            Map(p => p.CriadoPor).Column("Nome");
            Map(p => p.AtualizadoEm).Column("Nome");
            Map(p => p.AtualizadoPor).Column("Nome");
            Map(p => p.Ativo).Column("Nome");
        }
    }
}
