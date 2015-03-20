using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    class IL_ROOMTYPEMap : ClassMap<IL_ROOMTYPE> {
        public IL_ROOMTYPEMap() {
            Id(x => x.id);
            Map(x => x.RT_Key);
            Map(x => x.RT_Unicode);
            Map(x => x.RT_Code);
            Map(x => x.RT_Name);
            Map(x => x.RT_UpdateDate);
            Map(x => x.RT_ILKey);
            Map(x => x.RT_MTKey);
        }
    }
}
