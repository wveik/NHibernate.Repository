using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class IL_HOTELMap : ClassMap<IL_HOTEL> {
        public IL_HOTELMap() {
            Id(x => x.id);
            Map(x => x.HD_Key);
            Map(x => x.HD_Unicode);
            Map(x => x.HD_Name);
            Map(x => x.HD_UpdateDate);
            Map(x => x.HD_ILKey);
            Map(x => x.HD_MTKey);
            Map(x => x.HD_CityName);
            Map(x => x.HD_CTKEY);
        }
    }
}
