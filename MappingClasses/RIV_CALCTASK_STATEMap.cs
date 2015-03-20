using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class RIV_CALCTASK_STATEMap : ClassMap<RIV_CALCTASK_STATE> {
        public RIV_CALCTASK_STATEMap() {
            Id(x => x.TS_KEY);
            Map(x => x.TS_ITEM);
            Map(x => x.CST_CTKEY);
            Map(x => x.CST_HDCLC_START);
            Map(x => x.CST_HDCLC_NOW);
            Map(x => x.CST_HDCLC_MESS);
            Map(x => x.CST_SRVCLC_START);
            Map(x => x.CST_SRVCLC_NOW);
            Map(x => x.CST_SRVCLC_MESS);
            Map(x => x.CST_BOOKKEY_START);
            Map(x => x.CST_BOOKKEY_NOW);
            Map(x => x.CST_BOOKKEY_MESS);
            Map(x => x.CST_FILLHEAD_START);
            Map(x => x.CST_FILLHEAD_NOW);
            Map(x => x.CST_FILLHEAD_MESS);
            Map(x => x.CST_BOOKKEY_COUNT);
            Map(x => x.CST_HDCLC_COUNT);
            Map(x => x.CST_SRVCLC_COUNT);
            Map(x => x.CST_FILLHEAD_COUNT);
        }
    }
}
