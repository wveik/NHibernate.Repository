using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    class IL_SPOMap : ClassMap<IL_SPO> {
        public IL_SPOMap() {
            Id(x => x.SPT_ID);
            Map(x => x.SPT_KEY);
            Map(x => x.SPT_SVKEY);
            Map(x => x.SPT_DURATION_MIN);
            Map(x => x.SPT_DURATION_MAX);
            Map(x => x.SPT_SPONUMBER);
            Map(x => x.SPT_COMMENT);
            Map(x => x.SPT_SPOTYPE);
            Map(x => x.SPT_SPOSTATE);
            Map(x => x.SPT_TARIFKEY);
            Map(x => x.SPT_CREATEDATE);
            Map(x => x.SPT_BOOKINGDATE_FROM);
            Map(x => x.SPT_BOOKINGDATE_TO);
            Map(x => x.SPT_COUNTCOSTS);
            Map(x => x.SPT_MTSPOKEY);
            Map(x => x.SPT_ILKEY);
            Map(x => x.SPT_PARTNER_CREATEDATE);
        }
    }
}
