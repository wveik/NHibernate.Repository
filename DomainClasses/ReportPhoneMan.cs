using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class ReportPhoneMan {
        public virtual Int32 CI_KEY { get; set; }
        public virtual String CI_WHO { get; set; }
        public virtual DateTime CI_DATE_START_CALL { get; set; }
        public virtual DateTime CI_DATETIME_START_CALL { get; set; }
        public virtual DateTime CI_DATE_FINISH_CALL { get; set; }
        public virtual DateTime CI_DATETIME_FINISH_CALL { get; set; }
        public virtual Int32 CI_TOTAL_SECONDS { get; set; }
        public virtual Int32? CI_SUBSCRIBER_KEY { get; set; }
        public virtual String CI_SUBSCRIBER { get; set; }
        public virtual String CI_COMMENT { get; set; }
        public virtual Int32? CI_INFORMATION_KEY { get; set; }
        public virtual String CI_INFORMATION_TEXT { get; set; }
        public virtual String PM_PHONE_NUMBER { get; set; }
        public virtual String GL_PHONE_NUMBER { get; set; }
        public virtual String MAIN_TOPIC { get; set; }
        public virtual String TC_TEXT { get; set; }
        public virtual String TYPE_INN_OR_OUT { get; set; }
        public virtual String TYPEKEY { get; set; }
        public virtual String ANSWERKEY { get; set; }
        public virtual String CI_FIRST_CALL { get; set; }
        public virtual String CI_MANAGED_TO_TRANSFER_CALL { get; set; }
        public virtual String OF_TYPENAME { get; set; }
    }
}
