using SignalWire.Relay.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsTools.Interfaces
{
    public class SW_SmsMessage : ISmsMessage
    {
        public SW_SmsMessage(Message SW_Message)
        {
            Id = SW_Message.ID;
            Status = SW_Message.Direction.ToString() +"_"+ SW_Message.State.ToString();
            From = SW_Message.From;
            To = SW_Message.To;
            Message = SW_Message.Body;
            ChangedOn = DateTime.UtcNow;
        }
        public string? Id { get; set; }
        public string? Status { get; set; }
        public DateTime ChangedOn { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }
        public string? Message { get; set; }
    }
}
