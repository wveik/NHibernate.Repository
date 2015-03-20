using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class RIV_GETCalcTasksList {
        public virtual int id { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string tl_name { get; set; }
        public virtual int count_hd { get; set; }
        public virtual int tl_key { get; set; }
        public virtual int creator { get; set; }
        public virtual int can_edit { get; set; }
        public virtual string creator_name { get; set; }
        public virtual string status { get; set; }
        public virtual int status_id { get; set; }
        public virtual int weight { get; set; }
        public virtual string history { get; set; }
        public virtual string country_to { get; set; }
        public virtual string city_from { get; set; }
        public virtual DateTime date_from { get; set; }
        public virtual DateTime date_till { get; set; }
        public virtual DateTime START_AT { get; set; }
        public virtual int? TO_KEY { get; set; }
        public virtual DateTime? calc_start { get; set; }
        public virtual DateTime? calc_finish { get; set; }
        public virtual int TS_ACTIVE { get; set; }
        public virtual int? CST_BOOKKEY_COUNT { get; set; }
        public virtual int? ProcessorID { get; set; }
        public virtual string th_syserror { get; set; }
    }
}
