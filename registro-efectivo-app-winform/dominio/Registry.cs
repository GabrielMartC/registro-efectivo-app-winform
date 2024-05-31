using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Registro
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Decimal Amount { get; set; }
        public string TypeCoin { get; set; }
        public string Entity {  get; set; }
        bool Active { get; set; }

    }
}
