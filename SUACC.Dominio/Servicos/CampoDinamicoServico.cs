using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Servicos.Comum;

namespace SUACC.Dominio.Servicos
{   
    public class CampoDinamicoServico : Servico<CampoDinamico>, ICampoDinamicoServico
    {
        public CampoDinamicoServico(ICampoDinamicoRepositorio repositorio) : base(repositorio)
        {

        }
    }
}
