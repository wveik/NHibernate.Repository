using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class HotelDictionaryWithCity {
        public virtual Int32 HD_CNKEY { get; set; }
        public virtual Int32 HD_CTKEY { get; set; }
        public virtual Int32 HD_KEY { get; set; }
        public virtual String CT_NAME { get; set; }
        public virtual String HD_NAME { get; set; }
        public virtual String HD_STARS { get; set; }
        public virtual String HD_ADDRESS { get; set; }
        public virtual String HD_PHONE { get; set; }
        public virtual String HD_FAX { get; set; }
        public virtual short? HD_SITE { get; set; }
        public virtual String HD_DESCRIPT { get; set; }
        public virtual String HD_PERSONNAME { get; set; }
        public virtual String HD_PERSONAPP { get; set; }
        public virtual String HD_CODE { get; set; }
        public virtual Int32? HD_RSKEY { get; set; }
        public virtual String HD_EMAIL { get; set; }
        public virtual String HD_HTTP { get; set; }
        public virtual String HD_DESCROOM { get; set; }
        public virtual String HD_DESCMEAL { get; set; }
        public virtual String HD_DESCSERVICE { get; set; }
        public virtual String HD_DESCSPORT { get; set; }
        public virtual String HD_DESCEXCUR { get; set; }
        public virtual String HD_DESCHEALTH { get; set; }
        public virtual String HD_DISTANCE { get; set; }
        public virtual Int32? HD_WEB { get; set; }
        public virtual String HD_DESCRAZVL { get; set; }
        public virtual String HD_WEBIMAGE { get; set; }
        public virtual String HD_WEBIMAGE1 { get; set; }
        public virtual String HD_WEBIMAGE2 { get; set; }
        public virtual String HD_WEBIMAGE3 { get; set; }
        public virtual String HD_WEBIMAGE4 { get; set; }
        public virtual String HD_WEBIMAGE5 { get; set; }
        public virtual String HD_WEBIMAGE6 { get; set; }
        public virtual String HD_WEBIMAGE7 { get; set; }
        public virtual String HD_WEBIMAGE8 { get; set; }
        public virtual String HD_REMARK { get; set; }
        public virtual String HD_REMARK1 { get; set; }
        public virtual String HD_REMARK2 { get; set; }
        public virtual String HD_REMARK3 { get; set; }
        public virtual String HD_REMARK4 { get; set; }
        public virtual String HD_REMARK5 { get; set; }
        public virtual String HD_REMARK6 { get; set; }
        public virtual String HD_REMARK7 { get; set; }
        public virtual String HD_REMARK8 { get; set; }
        public virtual Char? HD_StdKey { get; set; }
        public virtual String HD_UNICODE { get; set; }
        public virtual DateTime HD_UPDATEDATE { get; set; }
        public virtual String hd_name2 { get; set; }
        public virtual String hd_stars2 { get; set; }
        public virtual Int32? hd_samehdkey { get; set; }
        public virtual DateTime? hd_lastdescriptupdate { get; set; }
        public virtual String HD_CHECKIN_HOUR { get; set; }
        public virtual String HD_CHECKOUT_HOUR { get; set; }
        public virtual short? HD_MinAge { get; set; }
        public virtual int? REAL_HOTEL_HD_KEY { get; set; }
        public virtual string REAL_HOTEL_HD_NAME { get; set; }
        public virtual byte HD_GROUP_WITH_WOMEN { get; set; }
    }
}
