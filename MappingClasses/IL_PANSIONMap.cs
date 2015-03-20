using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class IL_PANSIONMap : ClassMap<IL_PANSION> {
        public IL_PANSIONMap() {
            Id(x => x.id);
            Map(x => x.PN_Key);
            Map(x => x.PN_Code);
            Map(x => x.PN_Name);
            Map(x => x.PN_UpdateDate);
            Map(x => x.PN_ILKey);
            Map(x => x.PN_MTKey);
        }
    }
}
