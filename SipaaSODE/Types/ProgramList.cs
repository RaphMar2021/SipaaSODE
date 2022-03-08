using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipaaSODE.Types
{
    public class WithEventsList<T> : List<T>
    {

        public event EventHandler ItemAdded;
        public event EventHandler ItemRemoved;

        public new void Add(T item) // "new" to avoid compiler-warnings, because we're hiding a method from base-class
        {
            if (null != ItemAdded)
            {
                ItemAdded(this, new EventArgs());
            }
            base.Add(item);
        }

        public new void Remove(T item) // "new" to avoid compiler-warnings, because we're hiding a method from base-class
        {
            if (null != ItemRemoved)
            {
                ItemRemoved(this, new EventArgs());
            }
            base.Remove(item);
        }
    }
}
