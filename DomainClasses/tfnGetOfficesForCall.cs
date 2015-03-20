using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class tfnGetOfficesForCall {
        public virtual Int32 OF_KEY { get; set; }
        public virtual String OF_NAME { get; set; }
        public virtual String OF_ADDRESS { get; set; }
        public virtual String OF_PHONE { get; set; }
        public virtual String Subway { get; set; }
        public virtual String FirmName { get; set; }
        public virtual String OF_CityPhone { get; set; }
        public virtual short OF_TYPE { get; set; }
        public virtual String OF_TYPENAME { get; set; }
    }
}
