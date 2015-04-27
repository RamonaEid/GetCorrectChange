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

        public int Val
        {
            get { return 5; }
        }

        public Enums.CurrencyPluralType PluralName
        {
            get { return Enums.CurrencyPluralType.Nickels; }
        }
    }
}
