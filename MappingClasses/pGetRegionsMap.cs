using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    class pGetRegionsMap : ClassMap<pGetRegions> {
        public pGetRegionsMap() {
            Id(x => x.RG_KEY);
            Map(x => x.RG_CNKEY);
            Map(x => x.RG_NAME);
            Map(x => x.CN_NAME);
        }
    }
}
