using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class ArquivoMapper : ClassMapper<Arquivo>
    {
        public ArquivoMapper()
        {
            Table("Arquivos");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.ChaveEntidadeId).Column("ChaveEntidadeId");
            Map(p => p.Nome).Column("Nome");
            Map(p => p.Tamanho).Column("Tamanho");
            Map(p => p.Extensao).Column("Extensao");
            Map(p => p.Diretorio).Column("Diretorio");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
