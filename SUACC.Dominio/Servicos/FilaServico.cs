using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Servicos.Comum;


namespace SUACC.Dominio.Servicos
{
    public class FilaServico : Servico<Fila>, IFilaServico
    {
        public FilaServico(IFilaRepositorio repositorio) : base(repositorio)
        {

        }
    }
}
