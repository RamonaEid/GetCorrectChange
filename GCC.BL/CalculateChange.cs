using System.Collections.Generic;

namespace GCC.BL
{
    public class CalculateChange
    {
        public static List<TillMoney> GetCorrectChange(decimal change, List<ICurrency> excludeList)
        {
            var resultList = new List<TillMoney>();
            var curChange = change;
            var tillMoneyList = MoneyManager.CreateTypesOfMoneyInTillList(excludeList);
            foreach (var denom in tillMoneyList)
            {
                var tillResult = PullDenominationFromTill(curChange, denom.Val);
                AddToResultList(denom, tillResult, resultList);
                curChange = tillResult.Remainder;
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

        public static TillResult PullDenominationFromTill(decimal change, decimal denominationToPull)
        {
            return new TillResult
            {
                Result = decimal.Truncate(change / denominationToPull),
                Remainder = change % denominationToPull,
            };
        }

    }
}
