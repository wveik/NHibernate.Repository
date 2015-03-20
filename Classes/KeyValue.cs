using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RIVIERA.NHibernate.Repository.Classes {
    [Serializable]
    public class KeyValue : IEquatable<KeyValue> {

        public int KEY { get; set; }
        public string NAME { get; set; }

        public bool Equals(KeyValue other) {
            return this.KEY == other.KEY && this.NAME == this.NAME;
        }

        public override int GetHashCode() {
            int hashFirstName = NAME == null ? "".GetHashCode() : NAME.GetHashCode();
            int hashLastName = KEY.GetHashCode();

            return hashFirstName ^ hashLastName;
        }
    }
}
