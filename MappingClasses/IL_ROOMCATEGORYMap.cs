using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class IL_ROOMCATEGORYMap : ClassMap<IL_ROOMCATEGORY> {
        public IL_ROOMCATEGORYMap() {
            Id(x => x.id);
            Map(x => x.RC_Key);
            Map(x => x.RC_Unicode);
            Map(x => x.RC_Name);
            Map(x => x.RC_UpdateDate);
            Map(x => x.RC_ILKey);
            Map(x => x.RC_MTKey);
        }
    }
}
