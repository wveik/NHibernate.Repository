﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.Classes {
    public class ContainerForHotDates {
        public List<StringDateAndDayOffWeek> ListDate { get; set; }
        public List<InnerContainer> ListHotDates { get; set; }
    }
}
