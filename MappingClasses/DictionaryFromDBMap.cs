using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class DictionaryFromDBMap : ClassMap<DictionaryFromDB> {
        public DictionaryFromDBMap() {
            Id(x => x.DIC_KEY);
            Map(x => x.DIC_NAME);
        }
    }
}
