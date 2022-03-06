using SmsTools.Interfaces;

namespace SmsTools
{
    public class SignalWire : ISmsSend, ISmsReceive
    {

        public SignalWire()
        {

        }
        public ISmsMessage GetSms_ById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SendSms(ISmsMessage message)
        {
            throw new NotImplementedException();
        }
    }
}