using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pShowSalesForPeriodMap : ClassMap<pShowSalesForPeriod> {
        public pShowSalesForPeriodMap() {
            Id(x => x.ID);
            Map(x => x.DATE_SALE);
            Map(x => x.DateSale);
            Map(x => x.StartPoint);
            Map(x => x.Direction);
            Map(x => x.CountBooking);
            Map(x => x.Pax);
            Map(x => x.DG_RATE);
            Map(x => x.Gross);
            Map(x => x.Netto);
            Map(x => x.Profit);
            Map(x => x.CT_KEY);
            Map(x => x.CN_KEY);
            Map(x => x.ProfitForPax);
            Map(x => x.typeKey);
            Map(x => x.showWithBlochniki);
        }
    }
}
