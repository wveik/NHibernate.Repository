using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class pShowSalesForPeriod {
        public virtual Int32 ID { get; set; }
        public virtual DateTime DATE_SALE { get; set; }
        public virtual String DateSale { get; set; }
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
        public virtual Int32 typeKey { get; set; }
        public virtual Int32 showWithBlochniki { get; set; }
    }
}
