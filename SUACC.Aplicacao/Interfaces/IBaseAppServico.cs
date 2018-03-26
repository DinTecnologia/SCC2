using SUACC.Aplicacao.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUACC.Aplicacao.Interfaces
{
    public interface IBaseAppServico
    {
        MenuViewModel ObterMenu(string usuarioId, string url, string namespaceArea);
    }
}
