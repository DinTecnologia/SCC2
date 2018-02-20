using SUACC.Dominio.Validacoes;
using System;

namespace SUACC.Dominio.Entidades
{
    public partial class ClienteEndereco
    {
        public string Id { get; set; }
        public long Identidade { get; set; }
        public string ClienteId { get; set; }
        public string TipoEntidadeCampoValorId { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int? CidadeId { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public bool Principal { get; set; }
        public short Ordem { get; set; }
        public DateTime? CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public string AtualizadoPor { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }

        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual Cidade Cidade { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual EntidadeCampoValor EntidadeCampoValore { get; set; }
    }
}
