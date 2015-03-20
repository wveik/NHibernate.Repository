using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class pGetHotelPrice {
        public virtual int cs_key { get; set; }
        public virtual string TL_NAME { get; set; }
        public virtual string PR_NAME { get; set; }
        public virtual string SPO_NUMBER { get; set; }
        public virtual string PN_NAME { get; set; }
        public virtual int PN_KEY { get; set; }
        public virtual DateTime cs_date { get; set; }
        public virtual DateTime cs_dateend { get; set; }
        public virtual string rc_name { get; set; }
        public virtual string rm_name { get; set; }
        public virtual string ac_name { get; set; }
        public virtual string cs_rate { get; set; }
        public virtual double cs_costnetto { get; set; }
        public virtual double cs_cost { get; set; }
        public virtual string NetCheckIn { get; set; }
        public virtual int CS_FIRSTDAYNETTO { get; set; }
        public virtual string GrossCheckIn { get; set; }
        public virtual int CS_FIRSTDAYBRUTTO { get; set; }
        public virtual string CommissionPrice { get; set; }
        public virtual int cs_discount { get; set; }
        public virtual string Price_by { get; set; }
        public virtual int cs_byday { get; set; }
        public virtual int us_key { get; set; }
        public virtual string us_name { get; set; }
        public virtual DateTime cs_upddate { get; set; }
        public virtual DateTime? SPO_NETTO_ACTIVEFROM { get; set; }
        public virtual DateTime? SPO_ACTIVEFROM { get; set; }
        public virtual DateTime? SPO_NETTO_VALIDTILL { get; set; }
        public virtual DateTime? SPO_VALIDTILL { get; set; }
        public virtual int CS_SUBCODE1 { get; set; }
        public virtual int CS_SUBCODE2 { get; set; }
        public virtual int CS_PRKEY { get; set; }
        public virtual int CS_PKKEY { get; set; }
        public virtual int? CS_SPOKEY { get; set; }
        public virtual int ac_key { get; set; }
        public virtual int rc_key { get; set; }
        public virtual int rm_key { get; set; }
        public virtual short? CS_LONG { get; set; }
        public virtual short? CS_LONG_TILL { get; set; }
        public virtual DateTime? SPO_CREATEDATE { get; set; }

        public virtual int invalid_string { get; set; }
    }
}
