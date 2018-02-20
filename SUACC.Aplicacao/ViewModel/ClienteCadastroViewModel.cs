using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;

namespace SUACC.Aplicacao.ViewModel
{
    public class ClienteCadastroViewModel
    {
        public Guid Id { get; set; }
        public string TipoEntidadeCampoValoresId { get; set; }
        public string ClassificacaoId { get; set; }
        public string Documento { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime? Data { get; set; }
        public bool AceitaComunicados { get; set; }
        public string CanalComunicadosEntidadeCampoValoresId { get; set; }
        public string AtendimentoId { get; set; }
        public ValidationResult ValidationResult { get; private set; }
        public IEnumerable<ClienteEnderecoCadastroViewModel> Enderecos { get; set; }

        public ClienteCadastroViewModel()
        {
            Id = Guid.NewGuid();
            ValidationResult = new ValidationResult();
            Enderecos = new List<ClienteEnderecoCadastroViewModel>();
        }
    }
}
