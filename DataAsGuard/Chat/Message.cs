using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAsGuard.Chat
{
    public class Message : IEquatable<Message>
    {
        public string Sender { get; set; }
        public string Reciever { get; set; }
        public string MessageText { get; set; }
        public string Time { get; set; }
        public string fromkey { get; set; }
        public string otherkey { get; set; }
        public string hash { get; set; }
        //key?

        
        public bool Equals(Message other)
        {
            if (other == null) return false;
            //return (this.Sender.Equals(other.Sender) && this.Reciever.Equals(other.Reciever) && this.MessageText.Equals(other.MessageText) && this.otherkey.Equals(other.otherkey) && )
            return (this.Time.Equals(other.Time) && this.Sender.Equals(other.Sender) && this.Reciever.Equals(other.Reciever));
        }
    }
}


