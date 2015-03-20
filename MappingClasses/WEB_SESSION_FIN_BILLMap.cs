using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class WEB_SESSION_FIN_BILLMap : ClassMap<WEB_SESSION_FIN_BILL> {
        public WEB_SESSION_FIN_BILLMap() {
            Id(x => x.WSFB_KEY);
            Map(x => x.WSFB_USER);
            Map(x => x.WSFB_IP_ADDRESS);
            Map(x => x.WSFB_DATE_TIME_CREATE);
            Map(x => x.WSFB_DATE_TIME_LAST_UPDATE);
            Map(x => x.WSFB_BI_KEY);
        }
    }
}
