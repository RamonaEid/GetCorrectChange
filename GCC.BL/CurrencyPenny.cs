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

        public int Val
        {
            get { return 1; }
        }

        public Enums.CurrencyPluralType PluralName
        {
            get { return Enums.CurrencyPluralType.Pennies; }
        }
    }
}
