using System;
using SUACC.Dominio.Validacoes;
using System.Collections.Generic;

namespace SUACC.Dominio.Entidades
{
    public class CampoDinamico
    {
        public CampoDinamico()
        {
            EntidadeSecaoAbaCampoDinamicos = new HashSet<EntidadeSecaoAbaCampoDinamico>();
        }

        public string Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public bool Obrigatorio { get; set; }
        public string Script { get; set; }
        public string Atributos { get; set; }
        public bool CssProprio { get; set; }
        public bool PadraoFerramenta { get; set; }
        public DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public string AtualizadoPor { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }

        public virtual ICollection<EntidadeSecaoAbaCampoDinamico> EntidadeSecaoAbaCampoDinamicos { get; set; }
    }
}
