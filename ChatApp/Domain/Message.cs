using System;

namespace ChatApp.Domain
{
    public class Message
    {
        public DateTime TimeSent { get; set; }
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
        public string Messagesent { get; set; }
    }
}