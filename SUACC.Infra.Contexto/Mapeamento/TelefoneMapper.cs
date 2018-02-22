using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class TelefoneMapper : ClassMapper<Telefone>
    {
        public TelefoneMapper()
        {
            Table("Telefones");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.AtendimentoId).Column("AtendimentoId");
            Map(p => p.ClienteId).Column("ClienteId");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.Ddi).Column("Ddi");
            Map(p => p.Ddd).Column("Ddd");
            Map(p => p.Numero).Column("Numero");
            Map(p => p.SomenteNumero).Column("SomenteNumero");
            Map(p => p.StatusEntidadeCampoValoresId).Column("StatusEntidadeCampoValoresId");
            Map(p => p.TipoEntidadeCampoValoresId).Column("TipoEntidadeCampoValoresId");
        }
    }
}
