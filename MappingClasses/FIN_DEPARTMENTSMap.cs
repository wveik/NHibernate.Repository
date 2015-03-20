using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class FIN_DEPARTMENTSMap : ClassMap<FIN_DEPARTMENTS> {
        public FIN_DEPARTMENTSMap() {
            Id(x => x.DP_KEY);
            Map(x => x.DP_NAME);
        }
    }
}
