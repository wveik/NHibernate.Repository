using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;


namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class pGetHotelPriceMap : ClassMap<pGetHotelPrice> {
        public pGetHotelPriceMap() {
            Id(x => x.cs_key);
            Map(x => x.TL_NAME);
            Map(x => x.PR_NAME);
            Map(x => x.SPO_NUMBER);
            Map(x => x.PN_NAME);
            Map(x => x.cs_date);
            Map(x => x.rm_key);
            Map(x => x.cs_dateend);
            Map(x => x.rc_name);
            Map(x => x.rm_name);
            Map(x => x.ac_name);
            Map(x => x.cs_rate);
            Map(x => x.cs_costnetto);
            Map(x => x.cs_cost);
            Map(x => x.NetCheckIn);
            Map(x => x.CS_FIRSTDAYNETTO);
            Map(x => x.GrossCheckIn);
            Map(x => x.CS_FIRSTDAYBRUTTO);
            Map(x => x.CommissionPrice);
            Map(x => x.cs_discount);
            Map(x => x.Price_by);
            Map(x => x.cs_byday);
            Map(x => x.us_key);
            Map(x => x.us_name);
            Map(x => x.cs_upddate);
            Map(x => x.SPO_NETTO_ACTIVEFROM);
            Map(x => x.SPO_ACTIVEFROM);
            Map(x => x.SPO_NETTO_VALIDTILL);
            Map(x => x.SPO_VALIDTILL);
            Map(x => x.CS_SUBCODE1);
            Map(x => x.CS_SUBCODE2);
            Map(x => x.CS_PRKEY);
            Map(x => x.CS_PKKEY);
            Map(x => x.CS_SPOKEY);
            Map(x => x.ac_key);
            Map(x => x.rc_key);
            Map(x => x.PN_KEY);
            Map(x => x.CS_LONG);
            Map(x => x.CS_LONG_TILL);
            Map(x => x.SPO_CREATEDATE);
        }

    }
}
