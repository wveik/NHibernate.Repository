using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class IL_COSTSMap : ClassMap<IL_COSTS> {
        public IL_COSTSMap() {
            Id(x => x.id);
            Map(x => x.CTM_KEY);
            Map(x => x.CTM_ILKEY);
            Map(x => x.CTM_HDKEY);
            Map(x => x.CTM_PNKEY);
            Map(x => x.CTM_ACKEY);
            Map(x => x.CTM_RTKEY);
            Map(x => x.CTM_RCKEY);
            Map(x => x.CTM_DATE);
            Map(x => x.CTM_DATETO);
            Map(x => x.CTM_PRICE);
            Map(x => x.CTM_PRICERATE);
            Map(x => x.CTM_SPOKEY);
            Map(x => x.CTM_SVKEY);
            Map(x => x.CTM_TYPE);
            Map(x => x.CTM_WEEK);
            Map(x => x.CTM_IMPORTED);
            Map(x => x.CTM_NDAYS);
            Map(x => x.CTM_TSKEY);
            Map(x => x.CTM_MinimumStay);
            Map(x => x.CTM_MaximumStay);
            Map(x => x.CTM_FreeNights);
        }
    }
}
