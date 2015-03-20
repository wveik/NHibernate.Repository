using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RIVIERA.NHibernate.Repository.DomainClasses;

namespace RIVIERA.NHibernate.Repository.Classes {
    public class EqualityComparerSimpleKeyValue : IEqualityComparer<SimpleKeyValue> {
        #region IEqualityComparer<SimpleKeyValue> Members

        public bool Equals(SimpleKeyValue x, SimpleKeyValue y) {
            if (x.KEY == y.KEY && y.NAME == y.NAME) {
                return true;
            }            
            return false;
        }

        public int GetHashCode(SimpleKeyValue obj) {
            return obj.GetHashCode();
        }

        #endregion
    }
}
