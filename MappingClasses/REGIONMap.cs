using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class REGIONMap : ClassMap<REGION> {
        public REGIONMap() {
            Id(x => x.RG_KEY);
            Map(x => x.RG_CNKEY);
            Map(x => x.RG_NAME);
        }
    }
}
