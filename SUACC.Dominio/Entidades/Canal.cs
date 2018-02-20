using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;

namespace SUACC.Dominio.Entidades
{   
    public partial class Canal
    {
        public Canal()
        {
            Atendimentos = new HashSet<Atendimento>();
        }
    
        public string Id { get; set; }
        public int Identidade { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public DateTime? AtualizadoPor { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }
       
        public virtual ICollection<Atendimento> Atendimentos { get; set; }
    }
}
