using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsTools.Interfaces
{
    internal interface ISmsLocalDataBase
    {
        public ISmsMessage GetMessage(string id);
        public bool LogMessage(ISmsMessage message);
    }
}
