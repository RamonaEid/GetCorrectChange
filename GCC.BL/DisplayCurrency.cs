using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace GCC.BL
{
    public class DisplayCurrency
    {
        public static string GetPathameOfCurrencyImage(TillMoney money)
        {
            var pathname = "";
            if (money == null) return pathname;
            var name = money.Name;
            var pluralName = money.PluralName;
            var sb = new StringBuilder("~/images/", 21);
            sb.Append(money.Val <= 4 ? name.ToString() : pluralName.ToString()).Append(".png");
            pathname = sb.ToString();

            return pathname;
        }

        public static int GetNumberOfCurrencyImages(TillMoney money)
        {
            var imgNum = 0;
            var val = money.Val;
            if ((int)val < 0) return imgNum;
            imgNum = (int)val;

            return imgNum;
        }


    }
}
