using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class KICKBACKMap : ClassMap<KICKBACK> {
        public KICKBACKMap() {
            Id(x => x.KB_KEY);
            Map(x => x.KB_HDKEY);
            Map(x => x.KB_DATE_BEGIN);
            Map(x => x.KB_DATE_END);
            Map(x => x.KB_PROCENT);
            Map(x => x.KB_CREATEDATE);
            Map(x => x.KB_LASTUPDATE);
        }
    }
}
