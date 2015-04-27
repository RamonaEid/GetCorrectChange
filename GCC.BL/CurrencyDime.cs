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

        public int Val
        {
            get { return 10; }
        }

        public Enums.CurrencyPluralType PluralName
        {
            get { return Enums.CurrencyPluralType.Dimes; }
        }
    }
}
