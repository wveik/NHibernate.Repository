﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class HotelDictionaryForGroupHotel {
        public virtual Int32 HD_KEY { get; set; }
        public virtual Int32 HD_CNKEY { get; set; }
        public virtual Int32 HD_CTKEY { get; set; }
        public virtual String CT_NAME { get; set; }
        public virtual String HD_NAME { get; set; }
        public virtual String HD_STARS { get; set; }
    }
}
