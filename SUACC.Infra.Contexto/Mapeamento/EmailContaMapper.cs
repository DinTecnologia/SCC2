using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class EmailContaMapper : ClassMapper<EmailConta>
    {
        public EmailContaMapper()
        {
            Table("EmailContas");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.Nome).Column("Nome");
            Map(p => p.Email).Column("Email");
            Map(p => p.ServidorPop).Column("ServidorPop");
            Map(p => p.PortaPop).Column("PortaPop");
            Map(p => p.SslPop).Column("SslPop");
            Map(p => p.ServidorSmtp).Column("ServidorSmtp");
            Map(p => p.PortaSmtp).Column("PortaSmtp");
            Map(p => p.SslSmtp).Column("SslSmtp");
            Map(p => p.Login).Column("Login");
            Map(p => p.Senha).Column("Senha");
            Map(p => p.PadraoFerramenta).Column("PadraoFerramenta");
            Map(p => p.ContaPadrao).Column("ContaPadrao");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.AtualizadoEm).Column("AtualizadoEm");
            Map(p => p.AtualizadoPor).Column("AtualizadoPor");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
