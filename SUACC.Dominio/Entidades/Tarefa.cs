

namespace SUACC.Dominio.Entidades
{
    public class Tarefa : Atividade
    {
        //public string Id { get; set; }
        //public long Identidade { get; set; }
        public string AtividadeId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int TipoEntidadeCampoValorId { get; set; }

        public virtual Atividade Atividade { get; set; }
        //public ValidationResult ValidationResult { get; private set; }

    }
}
