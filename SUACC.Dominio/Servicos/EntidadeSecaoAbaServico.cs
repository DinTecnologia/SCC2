using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Servicos.Comum;

namespace SUACC.Dominio.Servicos

{   public class EntidadeSecaoAbaServico : Servico<EntidadeSecaoAba>, IEntidadeSecaoAbaServico
    {
        public EntidadeSecaoAbaServico(IEntidadeSecaoAbaRepositorio repositorio) : base(repositorio)
        {

        }
    }
}
