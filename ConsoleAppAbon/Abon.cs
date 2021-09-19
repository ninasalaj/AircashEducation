using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbon
{
    public class Abon
    {
        public string SerialNumber { get; set; }
        public decimal Amount { get; set; }
        public string CouponCode { get; set; }
        public List<string> InstructionsForUse { get; set; }
        public DateTime ExpirationDate { get; set; }
        public List<string> AdditionalInformation { get; set; }
        public List<string> Warning { get; set; }
        public Information1 HeaderData { get; set; }
        public Information2 Contact { get; set; }
    }
}
