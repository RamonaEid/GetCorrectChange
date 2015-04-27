using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCC.BL
{
    public class CurrencyFive : ICurrency
    {
        public Enums.CurrencyType Name
        {
            get { return Enums.CurrencyType.Five; }
        }

        public decimal Val
        {
            get { return 5.00M; }
        }

        public Enums.CurrencyPluralType PluralName
        {
            get { return Enums.CurrencyPluralType.Fives; }
        }
    }
}
