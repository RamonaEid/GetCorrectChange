using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCC.BL
{
    public class CurrencyHundred : ICurrency
    {
        public Enums.CurrencyType Name
        {
            get { return Enums.CurrencyType.Hundred; }
        }

        public decimal Val
        {
            get { return 100.00M; }
        }

        public Enums.CurrencyPluralType PluralName
        {
            get { return Enums.CurrencyPluralType.Hundreds; }
        }
    }
}
