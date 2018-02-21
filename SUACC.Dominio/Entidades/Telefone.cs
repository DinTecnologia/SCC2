using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;
using SUACC.Dominio.Entidades.Validacao.Telefones;

namespace SUACC.Dominio.Entidades
{
    public class Telefone
    {
        public Telefone()
        {
            Ligacoes = new List<Ligacao>();
            ValidationResult = new ValidationResult();
        }

        public Telefone(string atendimentoId, string clienteId, int statusEntidadeCampoValoresId,
            int tipoEntidadeCampoValoresId, int? ddi, int? ddd, long numero, string usuarioId)
        {
            AtendimentoId = atendimentoId;
            ClienteId = clienteId;
            StatusEntidadeCampoValoresId = statusEntidadeCampoValoresId;
            TipoEntidadeCampoValoresId = tipoEntidadeCampoValoresId;
            Ddi = ddi;
            Ddd = ddd;
            Numero = numero;
            SomenteNumero = (!ddi.HasValue && !ddd.HasValue);
            CriadoEm = DateTime.Now;
            CriadoPor = usuarioId;
            ValidationResult = new ValidationResult();
            Ligacoes = new List<Ligacao>();
        }

        public string Id { get; set; }
        public long Identidade { get; set; }
        public string ClienteId { get; set; }
        public string AtendimentoId { get; set; }
        public int StatusEntidadeCampoValoresId { get; set; }
        public int TipoEntidadeCampoValoresId { get; set; }
        public int? Ddi { get; set; }
        public int? Ddd { get; set; }
        public long Numero { get; set; }
        public bool SomenteNumero { get; set; }
        public DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public ValidationResult ValidationResult { get; private set; }

        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Atendimento Atendimento { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual EntidadeCampoValor EntidadeCampoValore { get; set; }
        public virtual EntidadeCampoValor EntidadeCampoValore1 { get; set; }
        public virtual ICollection<Ligacao> Ligacoes { get; set; }

        public virtual bool IsValid
        {
            get
            {
                ValidationResult = new TelefoneEstaConsistenteValidacao().Valid(this);
                return ValidationResult.IsValid;
            }
        }
    }
}
