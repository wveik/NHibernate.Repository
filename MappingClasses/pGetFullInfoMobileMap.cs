using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetFullInfoMobileMap : ClassMap<pGetFullInfoMobile> {
        public pGetFullInfoMobileMap() {
            Id(x => x.RT_ID);
            Map(x => x.DG_CODE);
            Map(x => x.DG_MAINMEN);
            Map(x => x.COUNT_TURISTS);
            Map(x => x.DATE_TRAVEL);
            Map(x => x.CN_NAME);
            Map(x => x.CT_NAME);
            Map(x => x.HD_NAME);
            Map(x => x.INSURE);
            Map(x => x.RATING);
        }
    }
}
