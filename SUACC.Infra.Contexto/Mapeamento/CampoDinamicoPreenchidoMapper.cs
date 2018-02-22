using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class CampoDinamicoPreenchidoMapper : ClassMapper<CampoDinamicoPreenchido>
    {
        public CampoDinamicoPreenchidoMapper()
        {
            Table("CampoDinamicoPreenchidos");
            Map(p => p.Id).Column("Id").Key(KeyType.Identity);
            Map(p => p.ChaveEntidade).Column("ChaveEntidade");
            Map(p => p.CampoDinamicoId).Column("CampoDinamicoId");
            Map(p => p.EntidadeSecaoAbaCampoDinamicoId).Column("EntidadeSecaoAbaCampoDinamicoId");
            Map(p => p.CampoDinamicoOpcoesId).Column("CampoDinamicoOpcoesId");
            Map(p => p.Valor).Column("Valor");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.Ativo).Column("Ativo");
        }
    }
}
