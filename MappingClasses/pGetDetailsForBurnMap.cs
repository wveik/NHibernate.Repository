using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetDetailsForBurnMap: ClassMap<pGetDetailsForBurn> {
        public pGetDetailsForBurnMap() {
            Id(x => x.ID);
            Map(x => x.BUSY);
            Map(x => x.CLASS);
            Map(x => x.DATE);
            Map(x => x.FLIGHT);
            Map(x => x.FREE);
            Map(x => x.PLACES);
            Map(x => x.WAIT);
        }
    }
}
