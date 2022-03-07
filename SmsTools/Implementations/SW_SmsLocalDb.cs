using SmsTools.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsTools.Implementations
{
    internal class SW_SmsLocalDb : ISmsLocalDataBase
    {
        private string ConnectionString { get; }
        public SW_SmsLocalDb(string connectionString)
        {
            ConnectionString = connectionString; 
        }
        public ISmsMessage GetMessage(string id)
        {
            throw new NotImplementedException();
        }

        public bool LogMessage(ISmsMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
