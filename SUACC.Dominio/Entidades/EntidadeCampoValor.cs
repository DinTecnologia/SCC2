using SUACC.Dominio.Validacoes;
using System;
using System.Collections.Generic;
using SUACC.Dominio.Entidades.ValuesObject;

namespace SUACC.Dominio.Entidades
{
    public class EntidadeCampoValor
    {
        public EntidadeCampoValor()
        {
            ClienteEnderecos = new HashSet<ClienteEndereco>();
            Clientes = new HashSet<Cliente>();
            Clientes1 = new HashSet<Cliente>();
            Mailings = new HashSet<Mailing>();
            Telefones = new HashSet<Telefone>();
            Telefones1 = new HashSet<Telefone>();
        }

        public int Id { get; set; }
        public int EntidadeId { get; set; }
        public string NomeCampo { get; set; }
        public string Valor { get; set; }
        public bool Padrao { get; set; }
        public int Ordem { get; set; }
        public DateTime CriadoEm { get; set; }
        public string CriadoPor { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public string AtualizadoPor { get; set; }
        public bool PadraoFerramenta { get; set; }
        public bool Ativo { get; set; }
        public ValidationResult ValidationResult { get; private set; }

        public virtual ICollection<ClienteEndereco> ClienteEnderecos { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Cliente> Clientes1 { get; set; }
        public virtual Entidade Entidade { get; set; }
        public virtual ICollection<Mailing> Mailings { get; set; }
        public virtual Remessa Remessa { get; set; }
        public virtual ICollection<Telefone> Telefones { get; set; }
        public virtual ICollection<Telefone> Telefones1 { get; set; }

        public void SetColunaTelefoneStatus()
        {
            NomeCampo = "StatusEntidadeCampoValoresId";
            EntidadeId = (int) EntidadeEnum.Telefone;
        }

        public void SetColunaTelefoneTipo()
        {
            NomeCampo = "TipoEntidadeCampoValoresId";
            EntidadeId = (int) EntidadeEnum.Telefone;
        }
    }
}
