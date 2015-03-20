using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class HotelDictionaryMap : ClassMap<HotelDictionary> {
        public HotelDictionaryMap() {
            Id(x => x.HD_KEY);
            Map(x => x.HD_CTKEY);
            Map(x => x.HD_CNKEY);
            Map(x => x.HD_NAME);
            Map(x => x.HD_STARS);
            Map(x => x.HD_ADDRESS);
            Map(x => x.HD_PHONE);
            Map(x => x.HD_FAX);
            Map(x => x.HD_SITE);
            Map(x => x.HD_DESCRIPT);
            Map(x => x.HD_PERSONNAME);
            Map(x => x.HD_PERSONAPP);
            Map(x => x.HD_CODE);
            Map(x => x.HD_RSKEY);
            Map(x => x.HD_EMAIL);
            Map(x => x.HD_HTTP);
            Map(x => x.HD_DESCROOM);
            Map(x => x.HD_DESCMEAL);
            Map(x => x.HD_DESCSERVICE);
            Map(x => x.HD_DESCSPORT);
            Map(x => x.HD_DESCEXCUR);
            Map(x => x.HD_DESCHEALTH);
            Map(x => x.HD_DISTANCE);
            Map(x => x.HD_WEB);
            Map(x => x.HD_DESCRAZVL);
            Map(x => x.HD_WEBIMAGE);
            Map(x => x.HD_WEBIMAGE1);
            Map(x => x.HD_WEBIMAGE2);
            Map(x => x.HD_WEBIMAGE3);
            Map(x => x.HD_WEBIMAGE4);
            Map(x => x.HD_WEBIMAGE5);
            Map(x => x.HD_WEBIMAGE6);
            Map(x => x.HD_WEBIMAGE7);
            Map(x => x.HD_WEBIMAGE8);
            Map(x => x.HD_REMARK);
            Map(x => x.HD_REMARK1);
            Map(x => x.HD_REMARK2);
            Map(x => x.HD_REMARK3);
            Map(x => x.HD_REMARK4);
            Map(x => x.HD_REMARK5);
            Map(x => x.HD_REMARK6);
            Map(x => x.HD_REMARK7);
            Map(x => x.HD_REMARK8);
            Map(x => x.ROWID);
            Map(x => x.HD_StdKey);
            Map(x => x.HD_UNICODE);
            Map(x => x.HD_UPDATEDATE);
            Map(x => x.hd_name2);
            Map(x => x.hd_stars2);
            Map(x => x.hd_samehdkey);
            Map(x => x.hd_lastdescriptupdate);
            Map(x => x.HD_CHECKIN_HOUR);
            Map(x => x.HD_CHECKOUT_HOUR);
            Map(x => x.HD_MinAge);
        }
    }
}
