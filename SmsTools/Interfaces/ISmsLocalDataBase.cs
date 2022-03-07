using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsTools.Interfaces
{
    internal interface ISmsLocalDataBase
    {
        public ISmsMessage GetMessage_ById(string id);
        public ISmsMessage GetMessage_BySender(string sender);
        public ISmsMessage GetMessage_ByRecipient(string sender);
        public bool LogMessage(ISmsMessage message);
    }
}
