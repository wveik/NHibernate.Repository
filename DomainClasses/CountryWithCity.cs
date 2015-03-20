using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class CountryWithCity {
        public virtual Int32 CN_KEY { get; set; }
        public virtual String CN_NAME { get; set; }
        public virtual Int32 CT_KEY { get; set; }
        public virtual String CT_NAME { get; set; }
    }
}
