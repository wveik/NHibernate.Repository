using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class CallInformation {
        public virtual Int32 CI_KEY { get; set; }
        public virtual String CI_WHO { get; set; }
        public virtual Int32 CI_GLKEY { get; set; }
        public virtual Int32 CI_PMKEY { get; set; }
        public virtual DateTime CI_DATE_START_CALL { get; set; }
        public virtual DateTime CI_DATETIME_START_CALL { get; set; }
        public virtual DateTime CI_DATE_FINISH_CALL { get; set; }
        public virtual DateTime CI_DATETIME_FINISH_CALL { get; set; }
        public virtual Int32 CI_TOTAL_SECONDS { get; set; }
        public virtual short CI_TYPE_INN_OR_OUT { get; set; }
        public virtual short CI_TYPEKEY { get; set; }
        public virtual Int32 CI_TCKEY { get; set; }
        public virtual Int32? CI_SUBSCRIBER_KEY { get; set; }
        public virtual String CI_SUBSCRIBER { get; set; }
        public virtual String CI_COMMENT { get; set; }
        public virtual short CI_ANSWERKEY { get; set; }
        public virtual Int32? CI_INFORMATION_KEY { get; set; }
        public virtual String CI_INFORMATION_TEXT { get; set; }
        public virtual short CI_FIRST_CALL { get; set; }
        public virtual short CI_MANAGED_TO_TRANSFER_CALL { get; set; }
        public virtual short CI_HIDE { get; set; }
        public virtual short? CI_TYPE_OFFICE { get; set; }
    }
}
