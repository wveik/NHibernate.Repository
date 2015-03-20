using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetHotDatesMap : ClassMap<pGetHotDates> {
        public pGetHotDatesMap() {
            Id(x => x.ID);
            Map(x => x.A_DATES);
            Map(x => x.FQ_DATES);
            Map(x => x.FQ_COUNT);
            Map(x => x.SP_DATES);
            Map(x => x.SP_COUNT);
            Map(x => x.FREE);
            Map(x => x.PROCENT);
            Map(x => x.CITY_FROM);
            Map(x => x.CITY_TO);
            Map(x => x.WITH_WHOLESALER);
            Map(x => x.STRING_DATE);
            Map(x => x.COUNTRY_TO);
            Map(x => x.ONLY_ECONOMY);
            Map(x => x.FirstStyle);
            Map(x => x.Sigma);
            Map(x => x.Pr_i);
            Map(x => x.PC_i);
            Map(x => x.Delta);
            Map(x => x.PC_i_PROC);
            Map(x => x.Pr_i_PROC);
            Map(x => x.SOLD_AMOUNT_TICKET_TODAY);
            Map(x => x.PROFIT_IN_THREE_DAY);
        }
    }
}
