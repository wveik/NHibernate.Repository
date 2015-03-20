using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    class KeyValueMap : ClassMap<KeyValue> {
        public KeyValueMap() {
            Id(x => x.FLAG);
            Map(x => x.ERROR);
        }
    }
}
