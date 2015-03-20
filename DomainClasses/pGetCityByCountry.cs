using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    [Serializable]
    public class pGetCityByCountry {
        public virtual int CT_KEY { get; set; }
        public virtual int CT_CNKEY { get; set; }
        public virtual String CT_NAME { get; set; }
        public virtual String CT_NAMELAT { get; set; }
    }
}
