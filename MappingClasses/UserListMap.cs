using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class UserListMap : ClassMap<UserList> {
        public UserListMap() {
            Id(x => x.US_KEY);
            Map(x => x.US_USERID);
            Map(x => x.US_POP3);
            Map(x => x.US_SMTP);
            Map(x => x.US_SHORTNAME);
            Map(x => x.US_BIRTHDAY);
            Map(x => x.US_JOB);
            Map(x => x.US_SUBSIDIARY);
            Map(x => x.US_ACCESSCHECKTIME);
            Map(x => x.US_ISIGNORQUOTE);
            Map(x => x.US_PRKEY);
            Map(x => x.US_SERVICE);
            Map(x => x.US_TURIST);
            Map(x => x.US_SERVICEM);
            Map(x => x.US_FNAME);
            Map(x => x.US_MAILBOX);
            Map(x => x.US_MAILUSER);
            Map(x => x.US_MAILPASS);
            Map(x => x.US_NAME);
            Map(x => x.US_SNAME);
            Map(x => x.US_WarningFlag);
            Map(x => x.US_SMKEY);
            Map(x => x.US_OFKEY);
            Map(x => x.US_ICQ);
            Map(x => x.US_GDS_PREFIX);
            Map(x => x.US_GDS_SUFFIX);
            Map(x => x.US_SmtpAuth);
            Map(x => x.US_SmtpLogin);
            Map(x => x.US_SmtpPass);
            Map(x => x.US_TSLOGIN);
            Map(x => x.US_DGPLKEY);
            Map(x => x.us_fullname);
        }
    }
}
