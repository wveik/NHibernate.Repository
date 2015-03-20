using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    class IL_STOPSALELISTMap : ClassMap<IL_STOPSALELIST> {
        public IL_STOPSALELISTMap() {
            Id(x => x.id);
            Map(x => x.SSL_KEY);
            Map(x => x.SSL_HDKEY);
            Map(x => x.SSL_RCKEY);
            Map(x => x.SSL_RTKEY);
            Map(x => x.SSL_DATEBEGIN);
            Map(x => x.SSL_DATEEND);
            Map(x => x.SSL_PRKEY);
            Map(x => x.SSL_RELPERIOD);
            Map(x => x.SSL_CANCELLED);
            Map(x => x.SSL_CREATEDATE);
            Map(x => x.SSL_ILKey);
            Map(x => x.MT_HDKey);
            Map(x => x.MT_RMKey);
            Map(x => x.MT_RCKey);
            Map(x => x.StatusID);
        }
    }
}
