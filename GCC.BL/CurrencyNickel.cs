using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCC.BL
{
    public class CurrencyNickel : ICurrency
    {
        public Enums.CurrencyType Name
        {
            get { return Enums.CurrencyType.Nickel; }
        }

        public decimal Val
        {
            get { return .05M; }
        }

        public Enums.CurrencyPluralType PluralName
        {
            get { return Enums.CurrencyPluralType.Nickels; }
        }
    }
}
