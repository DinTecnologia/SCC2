using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{   
    public  class EmailAnexoMapper : ClassMapper<EmailAnexo>
    {
        public EmailAnexoMapper()
        {
            Table("EmailAnexos");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.EmailId).Column("Nome");
            Map(p => p.Inline).Column("Nome");
            Map(p => p.ContentId).Column("Nome");
            Map(p => p.ArquivoId).Column("Nome");
            Map(p => p.Ativo).Column("Nome");
        }
    }
}
