using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetCountryFromForInvoiceMap : ClassMap<pGetCountryFromForInvoice> {
        public pGetCountryFromForInvoiceMap() {
            Id(x => x.CN_KEY);
            Map(x => x.CN_NAME);
            Map(x => x.CN_NAMELAT);
        }
    }
}
