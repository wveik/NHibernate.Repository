using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class UserList {
        public virtual Int32 US_KEY { get; set; }
        public virtual String US_USERID { get; set; }
        public virtual String US_POP3 { get; set; }
        public virtual String US_SMTP { get; set; }
        public virtual String US_SHORTNAME { get; set; }
        public virtual DateTime? US_BIRTHDAY { get; set; }
        public virtual String US_JOB { get; set; }
        public virtual String US_SUBSIDIARY { get; set; }
        public virtual Int32? US_ACCESSCHECKTIME { get; set; }
        public virtual short? US_ISIGNORQUOTE { get; set; }
        public virtual Int32? US_PRKEY { get; set; }
        public virtual Int32? US_SERVICE { get; set; }
        public virtual Int32? US_TURIST { get; set; }
        public virtual Int32? US_SERVICEM { get; set; }
        public virtual String US_FNAME { get; set; }
        public virtual String US_MAILBOX { get; set; }
        public virtual String US_MAILUSER { get; set; }
        public virtual String US_MAILPASS { get; set; }
        public virtual String US_NAME { get; set; }
        public virtual String US_SNAME { get; set; }
        public virtual short? US_WarningFlag { get; set; }
        public virtual Int32? US_SMKEY { get; set; }
        public virtual Int32? US_OFKEY { get; set; }
        public virtual String US_ICQ { get; set; }
        public virtual String US_GDS_PREFIX { get; set; }
        public virtual String US_GDS_SUFFIX { get; set; }
        public virtual Int32? US_SmtpAuth { get; set; }
        public virtual String US_SmtpLogin { get; set; }
        public virtual String US_SmtpPass { get; set; }
        public virtual String US_TSLOGIN { get; set; }
        public virtual Int32 US_DGPLKEY { get; set; }
        public virtual String us_fullname { get; set; }
    }
}
