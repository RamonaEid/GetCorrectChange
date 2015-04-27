using System.Collections.Generic;
using System.Linq;

namespace GCC.BL
{
    public static class MoneyManager
    {
        private static readonly CurrencyHundred CurrencyHundred = new CurrencyHundred();
        private static readonly CurrencyTwenty CurrencyTwenty = new CurrencyTwenty();
        private static readonly CurrencyTen CurrencyTen = new CurrencyTen();
        private static readonly CurrencyFive CurrencyFive = new CurrencyFive();
        private static readonly CurrencyOne CurrencyOne = new CurrencyOne();
        private static readonly CurrencyDime CurrencDime = new CurrencyDime();
        private static readonly CurrencyNickel CurrencyNickel = new CurrencyNickel();
        private static readonly CurrencyPenny CurrencyPenny = new CurrencyPenny();

        public static List<ICurrency> CreateMoneyList()
        {
            var moneyList = new List<ICurrency>
            {
                CurrencyHundred,
                CurrencyTwenty,
                CurrencyTen,
                CurrencyFive,
                CurrencyOne,
                CurrencDime,
                CurrencyNickel,
                CurrencyPenny
            };

            return moneyList;
        }

        public static List<ICurrency> CreateExcludeList(params ICurrency[] money)
        {
            var arrayList = money.ToList();
            var moneyList = CreateMoneyList();

            return arrayList.Where(item => moneyList.FindIndex(x => x.Name == item.Name) >= 0).ToList();
        }
        
        public static List<ICurrency> CreateTypesOfMoneyInTillList(List<ICurrency> excludeList)
        {
            var moneyList = CreateMoneyList();
            if (excludeList == null)
            {
                excludeList = new List<ICurrency>();
            }

            foreach (var money in excludeList)
            {
                switch (money.Name)
                {
                    case Enums.CurrencyType.Hundred:
                        moneyList.Remove(CurrencyHundred);
                        break;
                    case Enums.CurrencyType.Twenty:
                        moneyList.Remove(CurrencyTwenty);
                        break;
                    case Enums.CurrencyType.Ten:
                        moneyList.Remove(CurrencyTen);
                        break;
                    case Enums.CurrencyType.Five:
                        moneyList.Remove(CurrencyFive);
                        break;
                    case Enums.CurrencyType.One:
                        moneyList.Remove(CurrencyOne);
                        break;
                    case Enums.CurrencyType.Dime:
                        moneyList.Remove(CurrencDime);
                        break;
                    case Enums.CurrencyType.Nickel:
                        moneyList.Remove(CurrencyNickel);
                        break;
                }
            }

            return moneyList;
        }

        
    }
}