using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    class IL_ACCOMODATIONMap  : ClassMap<IL_ACCOMODATION> {
        public IL_ACCOMODATIONMap() {
            Id(x => x.id);
            Map(x => x.AC_Key);
            Map(x => x.AC_Unicode);
            Map(x => x.AC_Code);
            Map(x => x.AC_Name);
            Map(x => x.AC_UpdateDate);
            Map(x => x.AC_ILKey);
            Map(x => x.AC_MTKey);
        }
    }
}
