using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class LigacaoMapper : ClassMapper<Ligacao>
    {
        public LigacaoMapper()
        {
            Table("Ligacoes");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.AtividadeId).Column("Nome");
            Map(p => p.ClienteId).Column("Nome");
            Map(p => p.TelefoneId).Column("Nome");
            Map(p => p.TotalTentativaCliente).Column("Nome");
            Map(p => p.TotalTentativaTelefone).Column("Nome");
            Map(p => p.Direcao).Column("Nome");
            Map(p => p.CriadoEm).Column("Nome");
            Map(p => p.CriadoPor).Column("Nome");
        }
    }
}
