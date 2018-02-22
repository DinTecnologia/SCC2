using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;

namespace SUACC.Dominio.Entidades
{
    public class Classificacao
    {
        public Classificacao()
        {
            Atendimentos = new List<Atendimento>();
            Clientes = new List<Cliente>();
            Ocorrencias = new List<Ocorrencia>();
        }

        public string Id { get; set; }
        public long Identidade { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string EntidadeIds { get; set; }
        public string AtividadeTipoIds { get; set; }
        public string EntidadeIdsPadrao { get; set; }
        public string AtividadeTipoIdsPadrao { get; set; }
        public string Direcao { get; set; }
        public bool Finalizadora { get; set; }
        public DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public string AtualizadoPor { get; set; }
        public bool PadraoFerramenta { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }

        public virtual ICollection<Atendimento> Atendimentos { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Ocorrencia> Ocorrencias { get; set; }
    }
}
