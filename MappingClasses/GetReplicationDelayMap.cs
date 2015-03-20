using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class GetReplicationDelayMap : ClassMap<GetReplicationDelay> {
        public GetReplicationDelayMap() {
            Id(x => x.ID);
            Map(x => x.Latency);
            Map(x => x.ReplName);
        }
    }
}
