using System.Collections.Generic;
using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Servicos.Comum;

namespace SUACC.Dominio.Servicos
{
    public class MenuServico : Servico<Menu>, IMenuServico
    {
        private readonly IMenuRepositorio _menuRepositorio;

        public MenuServico(IMenuRepositorio repositorio) : base(repositorio)
        {
            _menuRepositorio = repositorio;
        }

        public IEnumerable<Menu> ObterPor(string usuarioId, string url, string aplicacaoId = null)
        {
            return _menuRepositorio.ObterPor(usuarioId, url, aplicacaoId);
        }
    }
}
