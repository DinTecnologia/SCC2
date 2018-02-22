using System;
using System.Collections.Generic;
using SUACC.Dominio.Validacoes;

namespace SUACC.Dominio.Entidades
{   
    public class Menu
    {
        public Menu()
        {
            ValidationResult = new ValidationResult();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public int MenuPaiId { get; set; }
        public string Tipo { get; set; }
        public string TipoAbertura { get; set; }
        public int Ordem { get; set; }
        public string Icone { get; set; }
        public string AreaId { get; set; }
        public string AplicacaoId { get; set; }
        public string FuncionalidadeId { get; set; }
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string AtualizadoPor { get; set; }
        public string AtualizadoEm { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }

        public virtual Anotacao Aplicacao { get; set; }
        public virtual Area Area { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual Funcionalidade Funcionalidade { get; set; }
        public virtual ICollection<Menu> Menus1 { get; set; }
        public virtual Menu Menu1 { get; set; }
    }
}
