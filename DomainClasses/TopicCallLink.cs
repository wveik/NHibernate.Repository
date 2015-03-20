using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class TopicCallLink {
        public virtual Int32 TCL_KEY { get; set; }
        public virtual short TCL_TYPEKEY { get; set; }
        public virtual Int32 TCL_TCKEY { get; set; }
        public virtual short TCL_HIDE { get; set; }
    }
}
