using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses
{
    public class pGetVisaTouristForSelectMap : ClassMap<pGetVisaTouristForSelect>
    {
        public pGetVisaTouristForSelectMap()
        {
            Id(x => x.TU_KEY);
            Map(x => x.DL_BRUTTO);
            Map(x => x.DL_COST);
            Map(x => x.DL_DATEBEG);
            Map(x => x.DL_DATEEND);
            Map(x => x.DL_KEY);
            Map(x => x.DL_NAME);
            Map(x => x.SL_NAME);
            Map(x => x.TU_BIRTHDAY);
            Map(x => x.TU_DGCOD);
            Map(x => x.TU_FNAMELAT);
            Map(x => x.TU_FNAMERUS);
            Map(x => x.TU_NAMELAT);
            Map(x => x.TU_NAMERUS);
            Map(x => x.TU_SNAMELAT);
            Map(x => x.TU_SNAMERUS);           
        }
    }
}
