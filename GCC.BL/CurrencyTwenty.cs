using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCC.BL
{
    public class CurrencyTwenty : ICurrency
    {
        public Enums.CurrencyType Name
        {
            get { return Enums.CurrencyType.Twenty; }
        }

        public int Val
        {
            get { return 2000; }
        }

        public Enums.CurrencyPluralType PluralName
        {
            get { return Enums.CurrencyPluralType.Twenties; }
        }
    }
}
