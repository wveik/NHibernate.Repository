using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class KeyValue {
        public virtual Int32 FLAG { get; set; }
        public virtual String ERROR { get; set; }

        public virtual List<String> InvoicesCodeList { get; set; }
    }
}
