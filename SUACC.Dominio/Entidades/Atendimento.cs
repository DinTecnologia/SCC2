using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;
using SUACC.Dominio.Entidades.Validacao.Atendimentos;

namespace SUACC.Dominio.Entidades
{
    public class Atendimento
    {
        public Atendimento()
        {
            AtendimentoInteracoes = new List<AtendimentoInteracao>();
            Clientes = new List<Cliente>();
            Ocorrencias = new List<Ocorrencia>();
            Telefones = new List<Telefone>();
            ValidationResult = new ValidationResult();
        }

        public string Id { get; set; }
        public long Identidade { get; set; }
        public int CanalId { get; set; }
        public string Protocolo { get; set; }
        public long? CampanhaId { get; set; }
        public DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public DateTime? FinalizadoEm { get; set; }
        public string FinalizadoPor { get; set; }
        public ValidationResult ValidationResult { get; private set; }

        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual ICollection<AtendimentoInteracao> AtendimentoInteracoes { get; set; }
        public virtual Canal Canai { get; set; }
        public virtual Classificacao Classificaco { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Ocorrencia> Ocorrencias { get; set; }
        public virtual ICollection<Telefone> Telefones { get; set; }

        public bool IsValid
        {
            get
            {
                if (ValidationResult.IsValid)
                    ValidationResult = new AtendimentoEstaConsistenteValidacao().Valid(this);

                return ValidationResult.IsValid;
            }
        }
    }
}
