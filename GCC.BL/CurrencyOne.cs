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

        public int Val
        {
            get { return 100; }
        }

        public Enums.CurrencyPluralType PluralName
        {
            get { return Enums.CurrencyPluralType.Ones; }
        }
    }
}
