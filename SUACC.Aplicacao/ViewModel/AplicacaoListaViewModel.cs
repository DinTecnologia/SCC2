using System;

namespace SUACC.Aplicacao.ViewModel
{
    public class AplicacaoListaViewModel
    {
        public string Id { get; set; }
        public string Nome { get; set; }

        public string Url { get; set; }
        public string Status { get; set; }
        public string CriadoPor { get; set; }
        public string CriadoEm { get; set; }
        public string AtualizadoEm { get; set; }
        public string AtualizadoPor { get; set; }
        public string Ssl { get; set; }

        public AplicacaoListaViewModel(string id, string nome, string url, bool ssl, bool ativo, string criadoPor, DateTime criadoEm, DateTime? atualizadoEm, string atualizadoPor)
        {
            Id = id;
            Nome = nome;
            Url = url;
            Status = ativo ? "Ativo" : "Inativo";
            CriadoPor = criadoPor;
            CriadoEm = criadoEm.ToString("dd/MM/yyyy HH:mm");
            AtualizadoEm = atualizadoEm.HasValue ? atualizadoEm.Value.ToString("dd/MM/yyyy HH:mm") : "--";
            AtualizadoPor = string.IsNullOrEmpty(atualizadoPor) ? "--" : AtualizadoPor;
            Ssl = ssl ? "Sim" : "Não";
        }
    }
}
