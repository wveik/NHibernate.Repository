using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class Airline {
        public virtual Int32 al_key { get; set; }
        public virtual String AL_CODE { get; set; }
        public virtual String AL_NAME { get; set; }
        public virtual Char? AL_StdKey { get; set; }
        public virtual Int32? AL_CODE_OFFICIAL { get; set; }
    }
}
