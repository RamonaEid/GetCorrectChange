using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCC.BL
{
    public class CurrencyPenny : ICurrency{
        public Enums.CurrencyType Name
        {
            get { return Enums.CurrencyType.Penny; }
        }

        public decimal Val
        {
            get { return .01M; }
        }

        public Enums.CurrencyPluralType PluralName
        {
            get { return Enums.CurrencyPluralType.Pennies; }
        }
    }
}
