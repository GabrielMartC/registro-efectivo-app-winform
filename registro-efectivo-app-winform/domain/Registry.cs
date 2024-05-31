using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Registry
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Decimal Amount { get; set; }
        public string TypeCoin { get; set; }
        public string Entity { get; set; }
        public bool Active { get; set; }
    }
}
