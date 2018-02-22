using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class FilaAtividadeMapper : ClassMapper<FilaAtividade>
    {
        public FilaAtividadeMapper()
        {
            Table("FilaAtividades");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.AtividadeId).Column("Nome");
            Map(p => p.FilaId).Column("Nome");
            Map(p => p.EntrouEm).Column("Nome");
            Map(p => p.SaiuEm).Column("Nome");
            Map(p => p.SaiuPor).Column("Nome");
            Map(p => p.Ativo).Column("Nome");
        }
    }
}
