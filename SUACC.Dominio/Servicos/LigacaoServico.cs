using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Servicos.Comum;

namespace SUACC.Dominio.Servicos
{
    public class LigacaoServico : Servico<Ligacao>, ILigacaoServico
    {
        private readonly ILigacaoRepositorio _repositorio;
        private readonly IClassificacaoServico _classificacaoServico;
        private readonly IAtendimentoServico _atendimentoServico;
        private readonly IAtividadeServico _atividadeServico;

        public LigacaoServico(ILigacaoRepositorio repositorio, IClassificacaoServico classificacaoServico,
            IAtendimentoServico atendimentoServico, IAtividadeServico atividadeServico)
            : base(repositorio)
        {
            _repositorio = repositorio;
            _classificacaoServico = classificacaoServico;
            _atendimentoServico = atendimentoServico;
            _atividadeServico = atividadeServico;
        }

        public Ligacao AdicionarReceptivo(string usuarioId, string telefoneId, string atendimentoId, long? campanhaId)
        {
            var retorno = new Ligacao
            {
                CriadoPor = usuarioId,
                TelefoneId = telefoneId,
                AtendimentoId = atendimentoId,
                Direcao = "S"
            };

            var classificacao = _classificacaoServico.ObterClassificacaoPadraoLigacaoReceptiva();
            if (!classificacao.ValidationResult.IsValid)
            {
                retorno.ValidationResult = classificacao.ValidationResult;
                return retorno;
            }

            retorno.ClassificacaoId = classificacao.Id;
            retorno.ValidationResult = _atividadeServico.Adicionar((Atividade) retorno);

            if (!retorno.ValidationResult.IsValid)
            {
                return retorno;
            }

            retorno.ValidationResult = Adicionar(retorno);
            return retorno;
        }

        ////public Ligacao AdicionarReceptivo(string usuarioId, string numeroTelefone, string informacaoUra, string codigoLigacao,
        ////    string ramalOperador, string atendimentoId,long? campanhaId , IDbTransaction transaction = null)
        //{
        //    var retorno = new Ligacao()
        //    {
        //        CriadoPor =  usuarioId,

        //    };
        //    //if (!string.IsNullOrEmpty(atendimentoId))
        //    //{
        //    //    var atendimento = _atendimentoServico.GerarEntidade(usuarioId, (int) CanalEnum.Telefonico, null,
        //    //        campanhaId);

        //    //       _atendimentoServico.Adicionar(atendimento, transaction);

        //    //    if (!atendimento.IsValid)
        //    //        return atendimento.ValidationResult;
        //    //}

        //    var classificacao = _classificacaoServico.ObterClassificacaoPadraoLigacaoReceptiva();

        //    if (!classificacao.ValidationResult.IsValid)
        //        return classificacao.ValidationResult;

        //    var ligacao = new Ligacao()
        //    {
        //        ClassificacaoId = classificacao.Id,

        //    };

        //    return null;
        //}
    }
}
