using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class pShowSalesForDate {
        public virtual Int32 ID { get; set; }
        public virtual String DateSale { get; set; }
        public virtual String TURDATE { get; set; }
        public virtual DateTime DG_TURDATE { get; set; }
        public virtual String DAY_OFF_WEEK { get; set; }
        public virtual String StartPoint { get; set; }
        public virtual String Direction { get; set; }
        public virtual Int32 CountBooking { get; set; }
        public virtual Int32 Pax { get; set; }
        public virtual String DG_RATE { get; set; }
        public virtual double? Gross { get; set; }
        public virtual double? Netto { get; set; }
        public virtual double? Profit { get; set; }
        public virtual double? ProfitForPax { get; set; }
        public virtual Int32 CT_KEY { get; set; }
        public virtual Int32 CN_KEY { get; set; }
        public virtual Int32 COUNT_ADULT { get; set; }
        public virtual Int32 COUNT_FREE_TICKET { get; set; }
        public virtual Int32 COUNT_FULL_TICKET { get; set; }
        public virtual Int32 typeKey { get; set; }
        public virtual Int32 showWithBlochniki { get; set; }
    }
}
