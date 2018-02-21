using System;
using System.Linq;
using SUACC.Dominio.Entidades;
using SUACC.Dominio.Entidades.ValuesObject;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Servicos.Comum;
using SUACC.Dominio.Validacoes;

namespace SUACC.Dominio.Servicos
{
    public class ClassificacaoServico : Servico<Classificacao>, IClassificacaoServico
    {
        private readonly IClassificacaoRepositorio _repositorio;

        public ClassificacaoServico(IClassificacaoRepositorio repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }

        public Classificacao ObterClassificacaoPadraoLigacaoReceptiva()
        {
            var classificacoes = _repositorio.ObterComum(null, null, Convert.ToInt32(EntidadeEnum.Ligacao).ToString(),
                null, null, null, null, false, null);


            return classificacoes.Any() ? classificacoes.FirstOrDefault() : null;
        }
    }
}
