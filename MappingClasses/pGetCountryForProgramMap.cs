using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetCountryForProgramMap : ClassMap<pGetCountryForProgram> {
        public pGetCountryForProgramMap() {
            Id(x => x.CN_KEY);
            Map(x => x.CN_CODE);
            Map(x => x.CN_NAME);
            Map(x => x.CN_NAMELAT);
            Map(x => x.VISA);
            Map(x => x.ACTIVE);
            Map(x => x.cn_Accounting_type);
            Map(x => x.CN_Disabled);
            Map(x => x.WEB_COUNTRY);
            Map(x => x.cn_id);
        }
    }
}
