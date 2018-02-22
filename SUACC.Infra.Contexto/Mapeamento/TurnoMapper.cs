using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{ 
    public  class TurnoMapper : ClassMapper<Turno>
    {
        public TurnoMapper()
        {
            Table("Turnos");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.Nome).Column("Nome");
            Map(p => p.HoraInicio).Column("HoraInicio");
            Map(p => p.HoraFim).Column("HoraFim");
            Map(p => p.PadraoFerramenta).Column("PadraoFerramenta");
            Map(p => p.CriadoEm).Column("CriadoEm");
            Map(p => p.CriadoPor).Column("CriadoPor");
            Map(p => p.AtualizadoEm).Column("AtualizadoEm");
            Map(p => p.AtualizadoPor).Column("AtualizadoPor");
            Map(p => p.Ativo).Column("Ativo");
        }

    }
}
