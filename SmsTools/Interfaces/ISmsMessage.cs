using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsTools.Interfaces
{
    public interface ISmsMessage
    {
        public string? Id { get; set; }
        public string? Status { get; set; }
        public DateTime ChangedOn { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }
        public string? Message { get; set; }
    }
}
