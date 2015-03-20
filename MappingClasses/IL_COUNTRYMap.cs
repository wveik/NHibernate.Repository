using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class IL_COUNTRYMap : ClassMap<IL_COUNTRY> {
        public IL_COUNTRYMap() {
            Id(x => x.CN_KEY);
            Map(x => x.CN_ILKEY);
            Map(x => x.CN_NAME);
            Map(x => x.CN_CODE);
            Map(x => x.CN_MTKEY);
            Map(x => x.CN_CREATEDATE);
        }
    }
}
