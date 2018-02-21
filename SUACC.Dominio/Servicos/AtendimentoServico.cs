using System.Data;
using System.Linq;
using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Servicos.Comum;
using SUACC.Dominio.Validacoes;

namespace SUACC.Dominio.Servicos
{
    public class AtendimentoServico : Servico<Atendimento>, IAtendimentoServico
    {
        IClassificacaoServico _classificacaoServico;

        public AtendimentoServico(IAtendimentoRepositorio repositorio, IClassificacaoServico classificacaoServico) : base(repositorio)
        {
            _classificacaoServico = classificacaoServico;
        }

        public override ValidationResult Adicionar(Atendimento entity, IDbTransaction transaction = null, int? commandTimeout = null)
        {

            //if (entity.Telefones.Any())
            //{
            //    var retornoNovoTelefone = _telefoneServico.Adicionar(entity.Telefones.FirstOrDefault(), transaction, commandTimeout);

            //    if(retornoNovoTelefone.IsValid)
            //        entity.

            //}



            return base.Adicionar(entity, transaction, commandTimeout);
        }
    }

}

