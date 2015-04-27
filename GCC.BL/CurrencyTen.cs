using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCC.BL
{
    public class CurrencyTen : ICurrency
    {
        public Enums.CurrencyType Name
        {
            get { return Enums.CurrencyType.Ten; }
        }

        public int Val
        {
            get { return 1000; }
        }

        public Enums.CurrencyPluralType PluralName
        {
            get { return Enums.CurrencyPluralType.Tens; }
        }
    }
}
