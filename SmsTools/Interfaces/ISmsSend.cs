using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsTools.Interfaces
{
    public interface ISmsSend
    {
        public bool SendSms(ISmsMessage message);
    }
}
