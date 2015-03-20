using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetAirServiceTaxMap : ClassMap<pGetAirServiceTax> {
        public pGetAirServiceTaxMap() {
            Id(x => x.AST_KEY);
            Map(x => x.AST_TAX);
            Map(x => x.AST_TL_KEY);
            Map(x => x.AST_AL_KEY);
            Map(x => x.AST_CITY_FLIGHT_FROM);
            Map(x => x.AST_CITY_FLIGHT_TO);
            Map(x => x.AST_COUNTRY_TO);
            Map(x => x.AST_DATE_FLIGHT_FINISH);
            Map(x => x.AST_DATE_FLIGHT_START);
            Map(x => x.AST_DATE_SALE_FINISH);
            Map(x => x.AST_DATE_SALE_START);
            Map(x => x.TL_KEY);
            Map(x => x.AL_KEY);
            Map(x => x.CITY_FLIGHT_FROM);
            Map(x => x.CITY_FLIGHT_TO);
            Map(x => x.COUNTRY_TO);
        }
    }
}
