using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class ClienteMapper : ClassMapper<Cliente>
    {
        public ClienteMapper()
        {
            Table("Clientes");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.TipoEntidadeCampoValoresId).Column("TipoEntidadeCampoValoresId");
            Map(p => p.ClassificacaoId).Column("ClassificacaoId");
            Map(p => p.Documento).Column("Documento");
            Map(p => p.Nome).Column("Nome");
            Map(p => p.Sobrenome).Column("Sobrenome");
            Map(p => p.Data).Column("Data");
            Map(p => p.AceitaComunicados).Column("AceitaComunicados");
            Map(p => p.CanalComunicadosEntidadeCampoValoresId).Column("CanalComunicadosEntidadeCampoValoresId");
            Map(p => p.AtendimentoId).Column("AtendimentoId");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.AtualizadoEm).Column("AtualizadoEm");
            Map(p => p.AtualizadoPor).Column("AtualizadoPor");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
