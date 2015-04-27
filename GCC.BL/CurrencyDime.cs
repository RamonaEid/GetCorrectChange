using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCC.BL
{
    public class CurrencyDime : ICurrency
    {
        public Enums.CurrencyType Name
        {
            get { return Enums.CurrencyType.Dime; }
        }

        public decimal Val
        {
            get { return .10M; }
        }

        public Enums.CurrencyPluralType PluralName
        {
            get { return Enums.CurrencyPluralType.Dimes; }
        }
    }
}
