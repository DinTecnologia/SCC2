using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;
namespace SUACC.Dominio.Entidades
{     
    public partial class Email : Atividade
    {
        public Email()
        {
            Anexos = new HashSet<EmailAnexo>();
        }

        //public string Id { get; set; }
        //public long Identidade { get; set; }
        public string AtividadeId { get; set; }
        public string Remetente { get; set; }
        public string Assunto { get; set; }
        public string Html { get; set; }
        public string MessageId { get; set; }
        public string UiD { get; set; }
        public string Corpo { get; set; }
        public string EmailPaiId { get; set; }
        public DateTime Data { get; set; }
        //public bool Ativo { get; set; }
        public string EmailContaDisparoId { get; set; }
        //public ValidationResult ValidationResult { get; private set; }


        public virtual Atividade Atividade { get; set; }
        public virtual ICollection<EmailAnexo> Anexos { get; set; }
        public virtual EmailConta Conta { get; set; }
    }
}
