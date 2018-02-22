using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class AnotacaoMapper : ClassMapper<Anotacao>
    {
        public AnotacaoMapper()
        {
            Table("Anotacoes");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.Descricao).Column("Descricao");
            Map(p => p.OcorrenciaId).Column("OcorrenciaId");
            Map(p => p.AtividadeId).Column("AtividadeId");
            Map(p => p.ClienteId).Column("ClienteId");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
