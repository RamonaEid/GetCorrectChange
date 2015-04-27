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

        public decimal Val
        {
            get { return 10.00M; }
        }

        public Enums.CurrencyPluralType PluralName
        {
            get { return Enums.CurrencyPluralType.Tens; }
        }
    }
}
