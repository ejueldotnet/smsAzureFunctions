using SmsTools.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace SmsTools
{
    internal class SignalWire : ISmsSendAndReceive
    {
        //In order to use the .NET client, you must get your project and token from your SignalWire dashboard
        private string ProjectId { get; }
        private string Token { get; }
        private ISmsLocalDataBase LocalDataBase { get; }

        public SignalWire(ISmsLocalDataBase localDb, string SW_ProjectId, string SW_Token)
        {
            LocalDataBase = localDb;
            ProjectId = SW_ProjectId;
            Token = SW_Token;
        }
        public ISmsMessage GetSms_ById(string id)
        {
            return LocalDataBase.GetMessage(id);
        }

        public bool ProcessIncomingMessage(SW_SmsMessage message)
        {
            //ToDo: Log incoming message to db and return true if successful
            return LocalDataBase.LogMessage(message);
        }


        public bool SendSms(SW_SmsMessage message)
        {
            throw new NotImplementedException();
        }

        ISmsMessage ISmsReceive.GetSms_ById(string id)
        {
            throw new NotImplementedException();
        }

        public bool ProcessIncomingMessage(ISmsMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
