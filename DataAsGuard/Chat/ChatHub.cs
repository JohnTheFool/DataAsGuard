using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAsGuard.CSClass;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Client;

namespace DataAsGuard.Chat
{
    
    public class ChatHub : BaseHub.Hub<ChatHub>
    {
        //public IHubProxy Proxy { get; set; }
        //public HubConnection Connection { get; set; }

        //public static string Host = "localhost.com";
        //Connection = new HubConnection(Host);
        //Assuming your SignalR hub is also called ChatHub (If you followed most tutorials it will be)
        //var Proxy = Connection.CreateHubProxy("ChatHub");
        //i only need connectedusers to track realtimeness
        static List<Users> ConnectedUsers = new List<Users>();

        //examples
        public async Task ItemHasChangedFromClient()
        {
            await ItemHasChangedAsync().ConfigureAwait(false);
        }
        /// <summary>Tells the clients that some item has changed.</summary>
        public static async Task ItemHasChangedAsync()
        {
            // my custom logic
            await HubContext.Clients.All.itemHasChanged();
        }
        

        //on login?
        public void Connect(string userName)
        {
            var id = Context.ConnectionId;

            if (ConnectedUsers.Count(x => x.ConnectionId == id) == 0)
            {
                //string UserImg = GetUserImage(userName);
                string logintime = DateTime.Now.ToString();
                ConnectedUsers.Add(new Users { ConnectionId = id, UserName = userName, /*UserImage = UserImg,*/ LoginTime = logintime });

                // send to caller  
                Clients.Caller.OnConnected(id, userName, ConnectedUsers/*, CurrentMessage*/);

                // send to all except caller client  
                Clients.AllExcept(id).onNewUserConnected(id, userName, /*UserImg,*/ logintime);
            }
        }

        //need this for disconnection
        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            var item = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == Context.ConnectionId);
            if (item != null)
            {
                ConnectedUsers.Remove(item);

                var id = Context.ConnectionId;
                Clients.All.onUserDisconnected(id, item.UserName);

            }
            return base.OnDisconnected(stopCalled);
        }
        //how they manipulate this method?
        public void SendPrivateMessage(string toUserId, string message)
        {

            string fromUserId = Context.ConnectionId;

            var toUser = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == toUserId);
            var fromUser = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == fromUserId);

            if (toUser != null && fromUser != null)
            {
                string CurrentDateTime = DateTime.Now.ToString();
                //string UserImg = GetUserImage(fromUser.UserName);
                
                // send to 
                Clients.Client(toUserId).sendPrivateMessage(fromUserId, fromUser.UserName, message, /*UserImg,*/ CurrentDateTime);

                // send to caller user
                Clients.Caller.sendPrivateMessage(toUserId, fromUser.UserName, message, /*UserImg,*/ CurrentDateTime);
            }

        }
        
    }
}
