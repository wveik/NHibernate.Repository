using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetReportTimingTheTaskMap : ClassMap<pGetReportTimingTheTask> {
        public pGetReportTimingTheTaskMap() {
            Id(x => x.ID);
            Map(x => x.TS_CREATEDATE);
            Map(x => x.TS_NEXTRUNTIME);
            Map(x => x.FROM_COUNTRY);
            Map(x => x.TILL_COUNTRY);
            Map(x => x.TYPE_TASK);
            Map(x => x.RANGE_TASK);
            Map(x => x.START_CALC);
            Map(x => x.FINISH_CALC);
            Map(x => x.TS_KEY);
            Map(x => x.CT_Weight);
            Map(x => x.CST_BOOKKEY_COUNT);
        }
    }
}
