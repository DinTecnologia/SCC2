using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;

namespace SUACC.Dominio.Entidades
{
    public partial class Tarefa : Atividade
    {
        //public string Id { get; set; }
        //public long Identidade { get; set; }
        public string AtividadeId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public virtual Atividade Atividade { get; set; }
        //public ValidationResult ValidationResult { get; private set; }

    }
}
