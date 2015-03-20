using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class AddNewPairMap : ClassMap<AddNewPair> {
        public AddNewPairMap() {
            Id(x => x.KEY);
            Map(x => x.NAME);
        }
    }
}
