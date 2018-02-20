using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Servicos.Comum;

namespace SUACC.Dominio.Servicos
{
    public class AspNetUserServico : Servico<AspNetUser>, IAspNetUserServico
    {

        public AspNetUserServico(IAspNetUserRepositorio repositorio) : base(repositorio)
        {

        }
    }
}
