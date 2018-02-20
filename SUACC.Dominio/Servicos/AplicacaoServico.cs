using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Servicos.Comum;

namespace SUACC.Dominio.Servicos
{
    public class AplicacaoServico : Servico<Aplicacao>, IAplicacaoServico
    {
        public AplicacaoServico(IAplicacaoRepositorio repositorio) : base(repositorio)
        {

        }
    }
}
