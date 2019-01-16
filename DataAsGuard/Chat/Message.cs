using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAsGuard.Chat
{
    public class Message
    {
        public string Messageid { get; set; }
        public string Sender { get; set; }
        public string Reciever { get; set; }
        public string MessageText { get; set; }
    }
}
