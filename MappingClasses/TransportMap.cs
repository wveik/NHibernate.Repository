using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class TransportMap : ClassMap<Transport> {
        public TransportMap() {
            Id(x => x.TR_KEY);
            Map(x => x.TR_NAME);
            Map(x => x.TR_NAMELAT);
            Map(x => x.TR_NMEN);
            Map(x => x.TR_StdKey);
            Map(x => x.TR_StrictUsage);
        }
    }
}
