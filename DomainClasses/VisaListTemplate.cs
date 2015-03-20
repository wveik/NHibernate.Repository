using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.DomainClasses
{
    public class VisaListTemplate
    {
        public virtual Int32 TEMPLATE_KEY { get; set; }
        public virtual Int32 COUNTRY_KEY { get; set; }
        public virtual String COUNTRY_NAME { get; set; }
    }
}
