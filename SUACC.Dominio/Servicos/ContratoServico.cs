using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Servicos.Comum;


namespace SUACC.Dominio.Servicos
{   
    public class ContratoServico : Servico<Contrato>, IContratoServico
    {
        public ContratoServico(IContratoRepositorio repositorio) : base(repositorio)
        {

        }
    }
}
