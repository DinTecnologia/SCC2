using SUACC.Dominio.Entidades;
using SUACC.Dominio.Interfaces.Repositorio;
using SUACC.Dominio.Interfaces.Servicos;
using SUACC.Dominio.Servicos.Comum;

namespace SUACC.Dominio.Servicos
{
    public class ConfiguracaoServico : Servico<Configuracao>,IConfiguracaoServico
    {
        public ConfiguracaoServico(IConfiguracaoRepositorio repositorio) : base(repositorio)
        {

        }
    }
}
