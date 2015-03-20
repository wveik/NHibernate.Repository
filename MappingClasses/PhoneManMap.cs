﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;
using FluentNHibernate.Mapping;

namespace RIVIERA.NHibernate.Repository.MappingClasses {
    public class PhoneManMap : ClassMap<PhoneMan> {
        public PhoneManMap() {
            Id(x => x.PM_KEY);
            Map(x => x.PM_USKEY);
            Map(x => x.PM_PHONE_NUMBER);
            Map(x => x.PM_GLKEY);
        }
    }
}
