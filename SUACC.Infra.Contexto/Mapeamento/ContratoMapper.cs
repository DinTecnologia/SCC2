using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class ContratoMapper : ClassMapper<Contrato>
    {
        public ContratoMapper()
        {
            Table("Contratos");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.Numero).Column("Nome");
            Map(p => p.ClienteId).Column("Nome");
            Map(p => p.Codigo).Column("Nome");
            Map(p => p.Nome).Column("Nome");
            Map(p => p.CriadoEm).Column("Nome");
            Map(p => p.CriadoPor).Column("Nome");
            Map(p => p.AtualizadoEm).Column("Nome");
            Map(p => p.AtualizadoPor).Column("Nome");
            Map(p => p.Ativo).Column("Nome");
        }
    }
}
