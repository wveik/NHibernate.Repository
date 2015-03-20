using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class IL_OBJECTMap : ClassMap<IL_OBJECT> {
        public IL_OBJECTMap() {
            Id(x => x.OB_Key);
            Map(x => x.OB_Object);
            Map(x => x.OB_Name);
            Map(x => x.OB_UpdateDate);
            Map(x => x.OB_ILKey);
        }
    }
}
