using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetCityByCountryMap : ClassMap<pGetCityByCountry> {
        public pGetCityByCountryMap() {
            Id(x => x.CT_KEY);
            Map(x => x.CT_CNKEY);
            Map(x => x.CT_NAME);
            Map(x => x.CT_NAMELAT);
        }
    }
}
