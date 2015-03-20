using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class OptionsMap : ClassMap<RIVIERA.NHibernate.Repository.DomainClasses.Options> {
        public OptionsMap() {
            Id(x => x.id);
            Map(x => x.IL_Key);
            Map(x => x.name);
            Map(x => x.value);
            Map(x => x.value_date);
        }
    }
}
