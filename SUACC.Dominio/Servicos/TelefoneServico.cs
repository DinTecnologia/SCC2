using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Servicos.Comum;

namespace SUACC.Dominio.Servicos
{   
    public class TelefoneServico : Servico<Telefone>, ITelefoneServico
    {
        private ITelefoneRepositorio _repositorio;
        private IEntidadeCampoValorServico _entidadeCampoValorServico;

        public TelefoneServico(ITelefoneRepositorio repositorio, IEntidadeCampoValorServico entidadeCampoValorServico)
            : base(repositorio)
        {
            _repositorio = repositorio;
            _entidadeCampoValorServico = entidadeCampoValorServico;
        }

        //public Telefone GerarEntidade(string atendimentoId, string clienteId, int statusEntidadeCampoValoresId,
        //    int tipoEntidadeCampoValoresId, int? ddi, int? ddd, long numero, string usuarioId)
        //{
        //    var retorno = new Telefone(atendimentoId, clienteId, statusEntidadeCampoValoresId,
        //        tipoEntidadeCampoValoresId, ddi, ddd, numero, usuarioId);


        //    if (statusEntidadeCampoValoresId <= 0)
        //    {
        //        var entidadeCampoValorStatusTelefone = new EntidadeCampoValor();
        //        entidadeCampoValorStatusTelefone.SetColunaTelefoneStatus();
        //        var status = _entidadeCampoValorServico.ObterPor(entidadeCampoValorStatusTelefone.EntidadeId,
        //            entidadeCampoValorStatusTelefone.NomeCampo, true);
        //    }
        //}
    }
}
