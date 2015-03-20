using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class QUOTESMap : ClassMap<QUOTES> {
        public QUOTESMap() {
            Id(x => x.QT_KEY);
            Map(x => x.QT_SVKEY);
            Map(x => x.QT_CODE);
            Map(x => x.QT_SUBCODE1);
            Map(x => x.QT_SUBCODE2);
            Map(x => x.QT_PRKEY);
            Map(x => x.QT_AGENT);
            Map(x => x.QT_DATE);
            Map(x => x.QT_BYCHECKIN);
            Map(x => x.QT_BYROOM);
            Map(x => x.QT_PLACES);
            Map(x => x.QT_RELEASE);
            Map(x => x.QT_OWNER);
            Map(x => x.QT_CREATEDATE);
            Map(x => x.QT_BUSY);
            Map(x => x.QT_Type);
            Map(x => x.QT_PayTerm);
            Map(x => x.QT_LastUpdate);
            Map(x => x.QT_ILQTKEY);
            Map(x => x.QT_ILKEY);
            Map(x => x.QT_FREE_PUBLIC);
            Map(x => x.QT_SMALL_LIMIT);
            Map(x => x.QT_FAST_LIMIT);
            Map(x => x.QT_TICKET_FREE_LIMIT);
        }
    }
}
