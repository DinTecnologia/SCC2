using SUACC.Dominio.Validacoes;
using SUACC.Dominio.Entidades.Validacao.Aplicacaoes;
using System;
using System.Collections.Generic;

namespace SUACC.Dominio.Entidades
{
    public class Aplicacao
    {
        public Aplicacao(string nome, string url, bool ssl, string criadoPor, string atualizadoPor, bool ativo)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Url = url;
            Ssl = ssl;
            CriadoPor = criadoPor;
            CriadoEm = DateTime.Now;
            AtualizadoPor = atualizadoPor;
            AtualizadoEm = string.IsNullOrEmpty(AtualizadoPor) ? (DateTime?)null : DateTime.Now;
            Ativo = ativo;
            Areas = new HashSet<Area>();
            Menus = new HashSet<Menu>();
        }

        public Guid Id { get; set; }
        public int Identidade { get; set; }
        public string Nome { get; set; }
        public string Url { get; set; }
        public bool Ssl { get; set; }
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string AtualizadoPor { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public bool Ativo { get; set; }
        public virtual AspNetUser UsuarioCriador { get; set; }
        public virtual AspNetUser UsuarioAtualizador { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }

        public ValidationResult ValidationResult { get; private set; }

        /// <summary>
        /// Retorno da Validação
        /// </summary>
        public bool IsValid
        {
            get
            {
                ValidationResult = new AplicacaoEstaConsistenteValidation().Valid(this);
                return ValidationResult.IsValid;
            }
        }        
    }
}
