using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses
{
    [Serializable]
    public class pGetSqlProcedureErrorMessage
    {
        public virtual int ERR_KEY { get; set; }
        public virtual string ERR_MESSAGE { get; set; }
    }
}
