using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses
{
    [Serializable]
    public class pGetVisaTouristList
    {
        public virtual int VTL_KEY { get; set; }
        public virtual string VTL_NAME { get; set; }
        public virtual int VTL_COUNTRY_KEY { get; set; }
        public virtual int VTL_PARTNER_KEY { get; set; }
        public virtual string VTL_COUNTRY_NAME { get; set; }
        public virtual string VTL_PARTNER_NAME { get; set; }
        public virtual string VTL_CURRENCY { get; set; }
        public virtual double VTL_COST { get; set; }
        public virtual int VTL_TOURIST_QUANTITY { get; set; }
        public virtual string VTL_STATE { get; set; }
        public virtual DateTime VTL_FIRST_TOUR_START { get; set; }
        public virtual DateTime VTL_LAST_TOUR_START { get; set; }
        public virtual string VTL_FIRST_TOUR_START_STRING { get; set; }
        public virtual string VTL_LAST_TOUR_START_STRING { get; set; }
        public virtual string VTL_COMMENT { get; set; }
        public virtual string VTL_PAYMENT_METHOD { get; set; }
        public virtual string CREATION_DATE { get; set; }
        public virtual string WHO_CREATED { get; set; }
        public virtual string MODIFICATION_DATE { get; set; }
        public virtual string WHO_MODIFIED { get; set; }
        public virtual int PREFERABLE_PAYMENT_WAY { get; set; }
    }
}
