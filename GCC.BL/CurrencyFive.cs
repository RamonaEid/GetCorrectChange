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

        public int Val
        {
            get { return 500; }
        }

        public Enums.CurrencyPluralType PluralName
        {
            get { return Enums.CurrencyPluralType.Fives; }
        }
    }
}
