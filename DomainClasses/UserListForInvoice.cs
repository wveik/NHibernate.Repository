using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class UserListForInvoice {
        public virtual Int32 US_KEY { get; set; }
        public virtual String US_USERID { get; set; }
        public virtual String US_JOB    { get; set; }
        public virtual String US_SUBSIDIARY { get; set; }
        public virtual String US_FNAME { get; set; }
        public virtual String US_NAME { get; set; }
    }
}
