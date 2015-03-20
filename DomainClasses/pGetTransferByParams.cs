using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class pGetTransferByParams {
        public virtual int TF_KEY { get; set; }
        public virtual String TF_NAME { get; set; }
        public virtual String TF_NAMELAT { get; set; }
    }
}
