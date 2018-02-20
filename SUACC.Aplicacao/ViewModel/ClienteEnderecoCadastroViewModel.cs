using SUACC.Dominio.Validacoes;
using System;

namespace SUACC.Aplicacao.ViewModel
{
    public class ClienteEnderecoCadastroViewModel
    {
        public Guid Id { get; set; }
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
        public bool Ativo { get; set; }
        public string UsuarioId { get; set; }
        public ValidationResult ValidationResult { get; private set; }

        public ClienteEnderecoCadastroViewModel()
        {
            Id = Guid.NewGuid();
            ValidationResult = new ValidationResult();
        }
    }
}
