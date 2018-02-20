using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Servicos.Comum;

namespace SUACC.Dominio.Servicos
{
    public class LigacaoServico : Servico<Ligacao>, ILigacaoServico
    {
        public LigacaoServico(ILigacaoRepositorio repositorio) : base(repositorio)
        {

        }
    }
}
