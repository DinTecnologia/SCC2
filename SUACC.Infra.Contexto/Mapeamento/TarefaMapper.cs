using DapperExtensions.Mapper;
using SUACC.Dominio.Entidades;

namespace SUACC.Infra.Contexto.Mapeamento
{
    public class TarefaMapper : ClassMapper<Tarefa>
    {
        public TarefaMapper()
        {
            Table("Tarefas");
            Map(p => p.Id).Column("Id");
            Map(p => p.Identidade).Column("Identidade").Key(KeyType.Identity);
            Map(p => p.AtividadeId).Column("Nome");
            Map(p => p.TipoEntidadeCampoValorId).Column("Nome");
            Map(p => p.Titulo).Column("Nome");
            Map(p => p.Descricao).Column("Nome");
        }
    }
}
