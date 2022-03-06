using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsTools.Interfaces
{
    public interface ISmsReceive
    {
        public ISmsMessage GetSms_ById(int id);
    }
}
