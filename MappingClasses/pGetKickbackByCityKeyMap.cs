using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    class pGetKickbackByCityKeyMap : ClassMap<pGetKickbackByCityKey> {
        public pGetKickbackByCityKeyMap() {
            Id(x => x.KB_KEY);
            Map(x => x.HD_NAME);
            Map(x => x.KB_HDKEY);
            Map(x => x.KB_DATE_BEGIN);
            Map(x => x.KB_DATE_END);
            Map(x => x.KB_PROCENT);
            Map(x => x.KB_CREATEDATE);
            Map(x => x.KB_LASTUPDATE);
            Map(x => x.CT_KEY);
            Map(x => x.CT_NAME);
        }
    }
}
