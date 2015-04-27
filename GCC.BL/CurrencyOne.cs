using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCC.BL
{
    public class CurrencyOne : ICurrency
    {
        public Enums.CurrencyType Name
        {
            get { return Enums.CurrencyType.One; }
        }

        public decimal Val
        {
            get { return 1.00M; }
        }

        public Enums.CurrencyPluralType PluralName
        {
            get { return Enums.CurrencyPluralType.Ones; }
        }
    }
}
