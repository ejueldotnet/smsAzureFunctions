﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsTools.Interfaces
{
    public interface ISmsReceive
    {
        public SmsMessage GetSms_ById(string id);
        public bool ProcessIncomingMessage(SmsMessage message);
    }
}
