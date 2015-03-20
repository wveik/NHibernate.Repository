using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class pGetAirServiceTax {
        public virtual int AST_KEY { get; set; }
        public virtual string AST_CITY_FLIGHT_FROM { get; set; }
        public virtual string AST_COUNTRY_TO { get; set; }
        public virtual string AST_CITY_FLIGHT_TO { get; set; }
        public virtual string AST_AL_KEY { get; set; }
        public virtual string AST_TL_KEY { get; set; }
        public virtual string AST_DATE_SALE_START { get; set; }
        public virtual string AST_DATE_SALE_FINISH { get; set; }
        public virtual string AST_DATE_FLIGHT_START { get; set; }
        public virtual string AST_DATE_FLIGHT_FINISH { get; set; }
        public virtual double AST_TAX { get; set; }
        public virtual int CITY_FLIGHT_FROM { get; set; }
        public virtual int COUNTRY_TO { get; set; }
        public virtual int CITY_FLIGHT_TO { get; set; }
        public virtual int AL_KEY { get; set; }
        public virtual int TL_KEY { get; set; }
    }
}
