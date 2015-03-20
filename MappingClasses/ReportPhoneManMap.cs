using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class ReportPhoneManMap: ClassMap<ReportPhoneMan> {
        public ReportPhoneManMap() {
            Id(x => x.CI_KEY);
            Map(x => x.ANSWERKEY);
            Map(x => x.CI_COMMENT);
            Map(x => x.CI_DATE_FINISH_CALL);
            Map(x => x.CI_DATE_START_CALL);
            Map(x => x.CI_DATETIME_FINISH_CALL);
            Map(x => x.CI_DATETIME_START_CALL);
            Map(x => x.CI_INFORMATION_KEY);
            Map(x => x.CI_INFORMATION_TEXT);
            Map(x => x.CI_SUBSCRIBER);
            Map(x => x.CI_SUBSCRIBER_KEY);
            Map(x => x.CI_TOTAL_SECONDS);
            Map(x => x.CI_WHO);
            Map(x => x.GL_PHONE_NUMBER);
            Map(x => x.PM_PHONE_NUMBER);
            Map(x => x.MAIN_TOPIC);
            Map(x => x.TC_TEXT);
            Map(x => x.TYPE_INN_OR_OUT);
            Map(x => x.TYPEKEY);
            Map(x => x.CI_FIRST_CALL);
            Map(x => x.CI_MANAGED_TO_TRANSFER_CALL);
            Map(x => x.OF_TYPENAME);
        }
    }
}
