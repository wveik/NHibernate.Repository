using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetTransportByParamsMap : ClassMap<pGetTransportByParams> {
        public pGetTransportByParamsMap() {
            Id(x => x.TR_KEY);
            Map(x => x.TR_NAME);
            Map(x => x.TR_NAMELAT);
        }
    }
}
