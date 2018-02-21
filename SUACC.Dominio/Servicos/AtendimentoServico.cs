using System;
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
        private readonly IAtendimentoRepositorio _repositorio;
        private readonly IUsuarioCampanhaServico _usuarioCampanhaServico;

        public AtendimentoServico(IAtendimentoRepositorio repositorio, IUsuarioCampanhaServico usuarioCampanhaServico)
            : base(repositorio)
        {
            _repositorio = repositorio;
            _usuarioCampanhaServico = usuarioCampanhaServico;
        }

        public Atendimento GerarEntidade(string usuarioId, int canalId, string protocolo, long? campanhaId)
        {
            var retorno = new Atendimento()
            {
                Id = Guid.NewGuid().ToString(),
                CriadoEm = DateTime.Now,
                CriadoPor = usuarioId,
                CanalId = canalId,
                CampanhaId = campanhaId,
                Protocolo =  protocolo
            };

            //Gerando Protocolo Provisório, ao inserir é gerado um último real
            if (string.IsNullOrEmpty(protocolo))
            {
                protocolo = _repositorio.ObterNovoProtocolo(canalId);

                if (string.IsNullOrEmpty(protocolo))
                {
                    retorno.ValidationResult.Add(new ValidationError("Problome ao gerar Protocolo de Atendimento."));
                    return retorno;
                }

                retorno.Protocolo = protocolo;
            }

            if (campanhaId.HasValue) return retorno;

            //Caso o operador esteja vinculado somente a uma campanha, já é setado automaticamente, quando ele possuir + que uma deverá setar no Front
            var usuarioCampanhas = _usuarioCampanhaServico.ObterPor(usuarioId, null);
            if (!usuarioCampanhas.Any())
            {
                retorno.ValidationResult.Add(new ValidationError("Usuário não possui Campanhas Vinculadas a ele"));
                return retorno;
            }

            if (usuarioCampanhas.Count() == 1)
                retorno.CampanhaId = usuarioCampanhas.FirstOrDefault().Id;

            return retorno;
        }
    }
}

