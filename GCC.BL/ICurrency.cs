using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCC.BL
{
    public interface ICurrency
    {
        Enums.CurrencyType Name { get; }
        decimal Val { get; }
        Enums.CurrencyPluralType PluralName { get; }
    }
}
