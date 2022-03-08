using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipaaSODE.Events
{
    public static class EventHelper
    {
        public static void Raise(this EventHandler eventHandler, object sender, EventArgs args)
        {
            if (eventHandler == null)
                return;
            eventHandler(sender, args);
        }
    }

    public class IconChanged
    {
        public event EventHandler FooEvent;
        public IconChanged()
        {

        }
        public void Execute()
        {
            //Do the work
            FooEvent.Raise(this, new EventArgs());
            //Continue the work
        }
    }
}
