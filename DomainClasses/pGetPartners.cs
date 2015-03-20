using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses
{
    [Serializable]
    public class pGetPartners
    {
        public virtual int PR_KEY { get; set; }
        public virtual string PR_FULLNAME { get; set; }
        public virtual string PR_NAME { get; set; }
    }
}
