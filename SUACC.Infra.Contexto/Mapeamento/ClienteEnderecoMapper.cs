using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class ClienteEnderecoMapper : ClassMapper<ClienteEndereco>
    {
        public ClienteEnderecoMapper()
        {
            Table("ClienteEnderecos");
            Map(p => p.Id).Column("Id").Key(KeyType.Identity);
            Map(p => p.ClienteId).Column("ClienteId");
            Map(p => p.TipoEntidadeCampoValorId).Column("TipoEntidadeCampoValorId");
            Map(p => p.Cep).Column("Cep");
            Map(p => p.Logradouro).Column("Logradouro");
            Map(p => p.CidadeId).Column("CidadeId");
            Map(p => p.Bairro).Column("Bairro");
            Map(p => p.Numero).Column("Numero");
            Map(p => p.Complemento).Column("Complemento");
            Map(p => p.Principal).Column("Principal");
            Map(p => p.Ordem).Column("Ordem");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.AtualizadoEm).Column("AtualizadoEm");
            Map(p => p.AtualizadoPor).Column("AtualizadoPor");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
