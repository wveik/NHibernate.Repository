using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.MappingClasses
{
    public class VisaListTemplateMap : ClassMap<VisaListTemplate>
    {
        public VisaListTemplateMap()
        {
            Id(x => x.TEMPLATE_KEY);
            Map(x => x.COUNTRY_KEY);
            Map(x => x.COUNTRY_NAME);
        }
    }
}
