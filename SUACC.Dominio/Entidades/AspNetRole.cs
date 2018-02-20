using SUACC.Dominio.Validacoes;
using System.Collections.Generic;

namespace SUACC.Dominio.Entidades
{
    public partial class AspNetRole
    {
        public AspNetRole()
        {
            AspNetUsers = new HashSet<AspNetUser>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public ValidationResult ValidationResult { get; private set; }
        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
    }
}
