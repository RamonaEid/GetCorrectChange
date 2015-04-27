using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCC.BL
{
    public class TillMoney
    {
        public Enums.CurrencyType Name { get; set; }
        public decimal Val { get; set; }
        public Enums.CurrencyPluralType PluralName { get; set; }
    }
}
