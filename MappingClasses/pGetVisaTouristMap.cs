using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses
{
    public class pGetVisaTouristMap : ClassMap<pGetVisaTourist>
    {
        public pGetVisaTouristMap()
        {
            Id(x => x.VTT_KEY);
            Map(x => x.DL_BRUTTO);
            Map(x => x.DL_COST);
            Map(x => x.DL_DATEBEG);
            Map(x => x.DL_DATEEND);
            Map(x => x.DL_KEY);
            Map(x => x.DL_NAME);
            Map(x => x.SL_NAME);
            Map(x => x.TU_FNAMERUS);
            Map(x => x.TU_NAMERUS);
            Map(x => x.VTT_LIST_KEY);
            Map(x => x.VTT_RESERVATION_CODE);
            Map(x => x.VTT_SERVICE_KEY);
            Map(x => x.VTT_STATE);
            Map(x => x.VTT_TOURIST_KEY);
        }
    }
}
