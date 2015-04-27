using System.Collections.Generic;

namespace GCC.BL
{
    public class CalculateChange
    {
        public static List<TillMoney> GetCorrectChange(int cents, List<ICurrency> excludeList)
        {
            var resultList = new List<TillMoney>();
            var curCents = cents;
            var tillMoneyList = MoneyManager.CreateTypesOfMoneyInTillList(excludeList);
            foreach (var denom in tillMoneyList)
            {
                var tillResult = PullDenominationFromTill(curCents, denom.Val);
                AddToResultList(denom, tillResult, resultList);
                curCents = tillResult.Remainder;
            }

            return resultList;
        }

        private static void AddToResultList(ICurrency denom, TillResult tillResult, List<TillMoney> resultList)
        {
            var denominationPulled = new TillMoney
            {
                Name = denom.Name,
                Val = tillResult.Result,
                PluralName = denom.PluralName
            };
            resultList.Add(denominationPulled);
        }

        public static TillResult PullDenominationFromTill(int cents, int denominationToPull)
        {
            return new TillResult
            {
                Result = cents / denominationToPull,
                Remainder = cents % denominationToPull,
            };
        }

    }
}
