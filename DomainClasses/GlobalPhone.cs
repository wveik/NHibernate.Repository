﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses {
    public class GlobalPhone {
        public virtual Int32 GL_KEY { get; set; }
        public virtual Int32 GL_CTKEY { get; set; }
        public virtual String GL_PHONE_NUMBER { get; set; }
    }
}
