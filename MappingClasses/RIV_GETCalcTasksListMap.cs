using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class RIV_GETCalcTasksListMap : ClassMap<RIV_GETCalcTasksList> {
        public RIV_GETCalcTasksListMap() {
            Id(x => x.id);
            Map(x => x.CreateDate);
            Map(x => x.tl_name);
            Map(x => x.count_hd);
            Map(x => x.tl_key);
            Map(x => x.creator);
            Map(x => x.can_edit);
            Map(x => x.creator_name);
            Map(x => x.status);
            Map(x => x.status_id);
            Map(x => x.weight);
            Map(x => x.history);
            Map(x => x.country_to);
            Map(x => x.city_from);
            Map(x => x.date_from);
            Map(x => x.date_till);
            Map(x => x.START_AT);
            Map(x => x.TO_KEY);
            Map(x => x.calc_start);
            Map(x => x.TS_ACTIVE);
            Map(x => x.CST_BOOKKEY_COUNT);
            Map(x => x.calc_finish);
            Map(x => x.ProcessorID);
            Map(x => x.th_syserror);
        }
    }
}
