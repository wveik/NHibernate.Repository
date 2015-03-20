using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class CityDictionaryMap : ClassMap<CityDictionary> {
        public CityDictionaryMap() {
            Id(x => x.CT_KEY);
            Map(x => x.CT_CNKEY);
            Map(x => x.CT_NAME);
            Map(x => x.CT_NAMELAT);
            Map(x => x.CT_CODE);
            Map(x => x.CT_CREATOR);
            Map(x => x.CT_UPDATEDATE);
            Map(x => x.ROWID);
            Map(x => x.CT_StdKey);
            Map(x => x.CT_WEB);
            Map(x => x.CT_WEBIMAGE);
            Map(x => x.CT_RSKEY);
            Map(x => x.CT_NAMEAC);
            Map(x => x.ct_rgid);
            Map(x => x.ct_dscr);
            Map(x => x.ct_timecorr);
            Map(x => x.CT_IsFomCity);
            Map(x => x.CT_RG_KEY);
            Map(x => x.RG_NAME);
        }
    }
}
