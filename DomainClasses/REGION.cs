using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class REGION {
        public virtual int RG_KEY { get; set; }
        public virtual int RG_CNKEY { get; set; }
        public virtual string RG_NAME { get; set; }
    }
}
