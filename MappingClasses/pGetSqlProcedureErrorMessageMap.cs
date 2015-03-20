using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.MappingClasses
{
    public class pGetSqlProcedureErrorMessageMap : ClassMap<pGetSqlProcedureErrorMessage>
    {
        public pGetSqlProcedureErrorMessageMap()
        {
            Id(x => x.ERR_KEY);
            Map(x => x.ERR_MESSAGE);
        }
    }
}
