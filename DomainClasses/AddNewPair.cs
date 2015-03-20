using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class AddNewPair {
        public virtual int KEY { get; set; }
        public virtual string NAME { get; set; }

        public virtual pGetHotDatesGroup DATA { get; set; }
    }
}
