using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class CidadeMapper : ClassMapper<Cidade>
    {
        public CidadeMapper()
        {
            Table("Cidades");
            Map(p => p.Id).Column("Id").Key(KeyType.Identity);
            Map(p => p.Nome).Column("Nome");
            Map(p => p.Uf).Column("Uf");
        }
    }
}
