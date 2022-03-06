using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsTools.Interfaces
{
    public interface ISmsMessage
    {
        string From { get; }
        string To { get; }
        int MessageId { get; }
        string Message { get; }
    }
}
