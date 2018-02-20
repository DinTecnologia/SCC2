using System;
using System.Data;

namespace SUACC.Infra.Contexto.Interfaces
{
    public interface IDapperContexto : IDisposable
    {
        IDbConnection Connection { get; }
    }
}
