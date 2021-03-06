using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;

namespace SUACC.Dominio.Entidades
{
    public partial class Funcionalidade
    {
        public Funcionalidade()
        {
            Menus = new HashSet<Menu>();
            ValidationResult = new ValidationResult();
        }
    
        public string Id { get; set; }
        public int Identidade { get; set; }
        public string Nome { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string Parametros { get; set; }
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string AtualizadoPor { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }
        
        public virtual ICollection<Menu> Menus { get; set; }
    }
}
