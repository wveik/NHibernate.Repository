using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pShowSalesForDateMap : ClassMap<pShowSalesForDate> {
        public pShowSalesForDateMap() {
            Id(x => x.ID);
            Map(x => x.DateSale);
            Map(x => x.StartPoint);
            Map(x => x.TURDATE);
            Map(x => x.DG_TURDATE);
            Map(x => x.DAY_OFF_WEEK);
            Map(x => x.Direction);
            Map(x => x.CountBooking);
            Map(x => x.Pax);
            Map(x => x.DG_RATE);
            Map(x => x.Gross);
            Map(x => x.Netto);
            Map(x => x.Profit);
            Map(x => x.CT_KEY);
            Map(x => x.CN_KEY);
            Map(x => x.COUNT_ADULT);
            Map(x => x.COUNT_FREE_TICKET);
            Map(x => x.COUNT_FULL_TICKET);
            Map(x => x.ProfitForPax);
            Map(x => x.typeKey);
            Map(x => x.showWithBlochniki);
        }
    }
}
