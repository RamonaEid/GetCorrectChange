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

        public decimal Val
        {
            get { return 20.00M; }
        }

        public Enums.CurrencyPluralType PluralName
        {
            get { return Enums.CurrencyPluralType.Twenties; }
        }
    }
}
