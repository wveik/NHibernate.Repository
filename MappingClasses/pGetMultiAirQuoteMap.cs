using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetMultiAirQuoteMap : ClassMap<pGetMultiAirQuote> {
        public pGetMultiAirQuoteMap() {
            Id(x => x.A_ID);
            Map(x => x.AS_KEY);
            Map(x => x.AS_NAMERUS);
        }
    }
}
