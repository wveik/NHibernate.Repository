using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class pGetOrderWebCountry {
        public virtual Int32 OWC_KEY { get; set; }
        public virtual Int32 OWC_CITY_FROM { get; set; }
        public virtual Int32 OWC_COUNTRY_TO { get; set; }
        public virtual Int32 OWC_ORDER { get; set; }
        public virtual string OWC_ORDER_STRING { get; set; }
        public virtual string CT_NAME { get; set; }
        public virtual string CN_NAME { get; set; }
        public virtual string OWC_FlightDef_string { get; set; }
        public virtual int? OWC_FlightDef { get; set; }
    }
}
