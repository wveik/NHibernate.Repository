using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class AirlineMap : ClassMap<Airline> {
        public AirlineMap() {
            Id(x => x.al_key);
            Map(x => x.AL_CODE);
            Map(x => x.AL_NAME);
            Map(x => x.AL_StdKey);
            Map(x => x.AL_CODE_OFFICIAL);
        }
    }
}
