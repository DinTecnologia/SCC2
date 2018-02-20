using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Servicos.Comum;

namespace SUACC.Dominio.Servicos
{
    public class TarefaServico : Servico<Tarefa> , ITarefaServico
    {
        public TarefaServico(ITarefaRepositorio repositorio) : base(repositorio)
        {

        }
    }
}
