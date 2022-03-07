using SmsTools.Interfaces;

namespace SmsTools.Implementations.SignalWire
{
    internal class SW_SendAndReceive : ISmsSendAndReceive
    {
        //In order to use the .NET client, you must get your project and token from your SignalWire dashboard
        private string ProjectId { get; }
        private string Token { get; }
        private ISmsLocalDataBase LocalDataBase { get; }

        public SW_SendAndReceive(ISmsLocalDataBase localDb, string SW_ProjectId, string SW_Token)
        {
            LocalDataBase = localDb;
            ProjectId = SW_ProjectId;
            Token = SW_Token;
        }
        public ISmsMessage GetSms_ById(string id)
        {
            return LocalDataBase.GetMessage_ById(id);
        }

        public bool ProcessIncomingMessage(SW_SmsMessage message)
        {
            //ToDo: Create webhook Azure Function to receive messages from Signal Wire
            // See: https://visualstudiomagazine.com/articles/2017/04/01/implementing-webhooks-azure-functions.aspx
            return LocalDataBase.LogMessage(message);
        }

        public bool ProcessIncomingMessage(ISmsMessage message)
        {
            throw new NotImplementedException();
        }

        public bool SendSms(ISmsMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
