using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class IL_RATESMap  : ClassMap<IL_RATES> {
        public IL_RATESMap() {
            Id(x => x.id);
            Map(x => x.IL_Code);
            Map(x => x.MT_Code);
            Map(x => x.IL_Key);
            Map(x => x.MT_Key);
            Map(x => x.IL_CREATEDATE);
        }
    }
}