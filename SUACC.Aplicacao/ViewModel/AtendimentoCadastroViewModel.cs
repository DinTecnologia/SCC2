using SUACC.Dominio.Validacoes;

namespace SUACC.Aplicacao.ViewModel
{
    public class AtendimentoCadastroViewModel
    {
        public string UsuarioId { get; set; }
        public long? CampanhaId { get; set; }
        public string ClienteId { get; set; }
        public long NumeroTelefone { get; set; }
        public ValidationResult ValidationResult { get; set; }

        public string AtendimentoId { get; set; }
        public string Protocolo { get; set; }
        public string LigacaoId { get; set; }
        public string EmailId { get; set; }

        public AtendimentoCadastroViewModel(string atendimentoId, string protocolo, string ligacaoId, string emailId)
        {
            AtendimentoId = atendimentoId;
            Protocolo = protocolo;
            LigacaoId = ligacaoId;
            EmailId = emailId;
            ValidationResult = new ValidationResult();
        }

        public AtendimentoCadastroViewModel()
        {
            ValidationResult = new ValidationResult();
        }
    }
}
