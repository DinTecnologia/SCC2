using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class EmailMapper : ClassMapper<Email>
    {
        public EmailMapper()
        {
            Table("Emails");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.AtividadeId).Column("AtividadeId");
            Map(p => p.Remetente).Column("Remetente");
            Map(p => p.Assunto).Column("Assunto");
            Map(p => p.Html).Column("Html");
            Map(p => p.MessageId).Column("MessageId");
            Map(p => p.UiD).Column("UiD");
            Map(p => p.Corpo).Column("Corpo");
            Map(p => p.EmailPaiId).Column("EmailPaiId");
            Map(p => p.Data).Column("Data");
            Map(p => p.Ativo).Column("Ativo");
            Map(p => p.EmailContaDisparoId).Column("EmailContaDisparoId");
        }
    }
}
