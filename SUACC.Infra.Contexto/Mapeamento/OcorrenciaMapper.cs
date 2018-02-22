using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class OcorrenciaMapper : ClassMapper<Ocorrencia>
    {
        public OcorrenciaMapper()
        {
            Table("Ocorrencias");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.Protocolo).Column("Protocolo");
            Map(p => p.MotivoId).Column("MotivoId");
            Map(p => p.ClassificacaoId).Column("ClassificacaoId");
            Map(p => p.Descricao).Column("Descricao");
            Map(p => p.ClienteId).Column("ClienteId");
            Map(p => p.ContratoId).Column("ContratoId");
            Map(p => p.AtendimentoId).Column("AtendimentoId");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.AtualizadoEm).Column("AtualizadoEm");
            Map(p => p.AtualizadoPor).Column("AtualizadoPor");
            Map(p => p.Finalizado).Column("Finalizado");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
