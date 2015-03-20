using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class DictionaryFromDB {
        public virtual int DIC_KEY { get; set; }
        public virtual string DIC_NAME { get; set; }
    }
}
