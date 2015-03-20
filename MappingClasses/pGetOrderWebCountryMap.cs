using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetOrderWebCountryMap : ClassMap<pGetOrderWebCountry> {
        public pGetOrderWebCountryMap() {
            Id(x => x.OWC_KEY);
            Map(x => x.OWC_CITY_FROM);
            Map(x => x.OWC_COUNTRY_TO);
            Map(x => x.OWC_ORDER);
            Map(x => x.CT_NAME);
            Map(x => x.CN_NAME);
            Map(x => x.OWC_FlightDef);
            Map(x => x.OWC_FlightDef_string);
            Map(x => x.OWC_ORDER_STRING);
        }
    }
}
