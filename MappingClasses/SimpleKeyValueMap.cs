using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class SimpleKeyValueMap : ClassMap<SimpleKeyValue> {
        public SimpleKeyValueMap() {
            Id(x => x.KEY);
            Map(x => x.NAME);
        }
    }
}
