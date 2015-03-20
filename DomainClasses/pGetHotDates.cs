using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class pGetHotDates {
        public virtual int ID { get; set; }
        public virtual DateTime A_DATES { get; set; }
        public virtual DateTime? FQ_DATES { get; set; }
        public virtual int? FQ_COUNT { get; set; }
        public virtual DateTime? SP_DATES { get; set; }
        public virtual int? SP_COUNT { get; set; }
        public virtual int? FREE { get; set; }
        public virtual int? PROCENT { get; set; }
        public virtual int CITY_FROM { get; set; }
        public virtual int CITY_TO { get; set; }
        public virtual int WITH_WHOLESALER { get; set; }
        public virtual string STRING_DATE { get; set; }
        public virtual int COUNTRY_TO { get; set; }
        public virtual int ONLY_ECONOMY { get; set; }
        public virtual int? FirstStyle { get; set; }
        public virtual double? Sigma { get; set; }
        public virtual double? Pr_i { get; set; }
        public virtual double? PC_i { get; set; }
        public virtual double? Delta { get; set; }
        public virtual int? Pr_i_PROC { get; set; }
        public virtual int? PC_i_PROC { get; set; }
        public virtual int? SOLD_AMOUNT_TICKET_TODAY { get; set; }
        public virtual double? PROFIT_IN_THREE_DAY { get; set; }


        public virtual bool Selected { get; set; }
    }
}
