using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Servicos.Comum;


namespace SUACC.Dominio.Servicos
{
    public class AnotacaoServico : Servico<Anotacao>, IAnotacaoServico
    {
        public AnotacaoServico(IAnotacaoRepositorio repositorio) : base(repositorio)
        {

        }
    }
}
