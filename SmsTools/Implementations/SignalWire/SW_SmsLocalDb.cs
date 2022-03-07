using Microsoft.Extensions.Logging;
using SmsTools.Interfaces;

namespace SmsTools.Implementations.SignalWire
{
    internal class SW_SmsLocalDb : ISmsLocalDataBase
    {
        public ILogger Log { get; }
        private string ConnectionString { get; }
        public SW_SmsLocalDb(ILogger log,string connectionString)
        {
            Log = log;
            ConnectionString = connectionString; 
        }
        public bool LogMessage(ISmsMessage msg)
        {
            //ToDo: Log incoming message to db and return true if successful
            Log.LogInformation($"Logging message {msg.Id} from/to: {msg.From}/{msg.To} Body: {msg.Message}");
            return true;
        }
        public ISmsMessage GetMessage_ById(string id)
        {
            throw new NotImplementedException();
        }

        public ISmsMessage GetMessage_BySender(string sender)
        {
            throw new NotImplementedException();
        }

        public ISmsMessage GetMessage_ByRecipient(string sender)
        {
            throw new NotImplementedException();
        }
    }
}
