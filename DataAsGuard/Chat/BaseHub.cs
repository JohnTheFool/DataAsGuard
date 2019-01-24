using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace DataAsGuard.Chat
{
    public class BaseHub
    {
        public abstract class Hub<T> : Hub where T : Hub
        {
            private static IHubContext hubContext;
            /// <summary>Gets the hub context.</summary>
            /// <value>The hub context.</value>
            public static IHubContext HubContext
            {
                get
                {
                    if (hubContext == null)
                        hubContext = GlobalHost.ConnectionManager.GetHubContext<T>();
                    return hubContext;
                }
            }
        }
    }
}
