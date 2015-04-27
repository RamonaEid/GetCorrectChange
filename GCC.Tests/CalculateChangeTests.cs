using System.Collections.Generic;
using GCC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GCC.Tests
{
    [TestClass]
    public class CalculateChangeTests
    {
        List<ICurrency> _moneyList = new List<ICurrency>();
        
        [TestInitialize]
        public void Initialize()
        {
            _moneyList.Add(new CurrencyHundred());
            _moneyList.Add(new CurrencyTwenty());
            _moneyList.Add(new CurrencyTen());
            _moneyList.Add(new CurrencyFive());
            _moneyList.Add(new CurrencyOne());
            _moneyList.Add(new CurrencyDime());
            _moneyList.Add(new CurrencyNickel());
            _moneyList.Add(new CurrencyPenny());
        }

        [TestCleanup]
        public void Cleanup()
        {
            _moneyList = new List<ICurrency>();
        }

        [TestMethod]
        public void GetCorrectChangeWithZeroCents_EmptyExcludeListTest()
        {
            var cents = 0;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney {Name = denom.Name, PluralName = denom.PluralName};
                switch (denom.Name)
                {
                    case Enums.CurrencyType.Hundred:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Twenty:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Ten:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Five:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.One:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Dime:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Nickel:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Penny:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                }
            }
            var expected = resultList;

            var actual = CalculateChange.GetCorrectChange(cents, MoneyManager.CreateExcludeList());

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }

        }

        [TestMethod]
        public void GetCorrectChangeWithFortyEightCents_EmptyExcludeListTest()
        {
            var cents = 48;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney {Name = denom.Name, PluralName = denom.PluralName};
                switch (denom.Name)
                {
                    case Enums.CurrencyType.Hundred:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Twenty:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Ten:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Five:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.One:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Dime:
                        tillMoney.Val = 4;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Nickel:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Penny:
                        tillMoney.Val = 3;
                        resultList.Add(tillMoney);
                        break;
                }
            }
            var expected = resultList;

            var actual = CalculateChange.GetCorrectChange(cents, MoneyManager.CreateExcludeList());

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }

        }

        [TestMethod]
        public void GetCorrectChangeWithOneHundredFortyEightCents_EmptyExcludeListTest()
        {
            var cents = 148;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney {Name = denom.Name, PluralName = denom.PluralName};
                switch (denom.Name)
                {
                    case Enums.CurrencyType.Hundred:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Twenty:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Ten:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Five:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.One:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Dime:
                        tillMoney.Val = 4;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Nickel:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Penny:
                        tillMoney.Val = 3;
                        resultList.Add(tillMoney);
                        break;
                }
            }
            var expected = resultList;

            var actual = CalculateChange.GetCorrectChange(cents, MoneyManager.CreateExcludeList());

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }

        }

        [TestMethod]
        public void GetCorrectChangeWithSixHundredFortyEightCents_EmptyExcludeListTest()
        {
            var cents = 648;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney {Name = denom.Name, PluralName = denom.PluralName};
                switch (denom.Name)
                {
                    case Enums.CurrencyType.Hundred:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Twenty:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Ten:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Five:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.One:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Dime:
                        tillMoney.Val = 4;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Nickel:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Penny:
                        tillMoney.Val = 3;
                        resultList.Add(tillMoney);
                        break;
                }
            }
            var expected = resultList;

            var actual = CalculateChange.GetCorrectChange(cents, MoneyManager.CreateExcludeList());

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }

        }

        [TestMethod]
        public void GetCorrectChangeWithOneThousandSixHundredFortyEightCents_EmptyExcludeListTest()
        {
            var cents = 1648;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney {Name = denom.Name, PluralName = denom.PluralName};
                switch (denom.Name)
                {
                    case Enums.CurrencyType.Hundred:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Twenty:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Ten:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Five:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.One:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Dime:
                        tillMoney.Val = 4;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Nickel:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Penny:
                        tillMoney.Val = 3;
                        resultList.Add(tillMoney);
                        break;
                }
            }
            var expected = resultList;

            var actual = CalculateChange.GetCorrectChange(cents, MoneyManager.CreateExcludeList());

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }

        }

        [TestMethod]
        public void GetCorrectChangeWithTwoThousandSixHundredFortyEightCents_EmptyExcludeListTest()
        {
            var cents = 2648;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney {Name = denom.Name, PluralName = denom.PluralName};
                switch (denom.Name)
                {
                    case Enums.CurrencyType.Hundred:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Twenty:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Ten:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Five:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.One:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Dime:
                        tillMoney.Val = 4;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Nickel:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Penny:
                        tillMoney.Val = 3;
                        resultList.Add(tillMoney);
                        break;
                }
            }
            var expected = resultList;

            var actual = CalculateChange.GetCorrectChange(cents, MoneyManager.CreateExcludeList());

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }

        }

        [TestMethod]
        public void GetCorrectChangeWithTenThousandSixHundredFortyEightCents_EmptyExcludeListTest()
        {
            var cents = 10648;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney {Name = denom.Name, PluralName = denom.PluralName};
                switch (denom.Name)
                {
                    case Enums.CurrencyType.Hundred:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Twenty:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Ten:
                        tillMoney.Val = 0;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Five:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.One:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Dime:
                        tillMoney.Val = 4;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Nickel:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Penny:
                        tillMoney.Val = 3;
                        resultList.Add(tillMoney);
                        break;
                }
            }
            var expected = resultList;

            var actual = CalculateChange.GetCorrectChange(cents, MoneyManager.CreateExcludeList());

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }

        }

        [TestMethod]
        public void GetCorrectChangeWithThirteenThousandSixHundredSixteenCents_EmptyExcludeListTest()
        {
            var cents = 13616;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney {Name = denom.Name, PluralName = denom.PluralName};
                switch (denom.Name)
                {
                    case Enums.CurrencyType.Hundred:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Twenty:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Ten:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Five:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.One:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Dime:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Nickel:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Penny:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                }
            }
            var expected = resultList;

            var actual = CalculateChange.GetCorrectChange(cents, MoneyManager.CreateExcludeList());

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }

        }
        

        [TestMethod]
        public void GetCorrectChangeWithThirteenThousandSixHundredSixteenCents_ExcludeHundredTest()
        {
            var cents = 13616;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney {Name = denom.Name, PluralName = denom.PluralName};
                switch (denom.Name)
                {
                    case Enums.CurrencyType.Hundred:
                        break;
                    case Enums.CurrencyType.Twenty:
                        tillMoney.Val = 6;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Ten:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Five:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.One:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Dime:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Nickel:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Penny:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                }
            }
            var expected = resultList;

            var excludeList = MoneyManager.CreateExcludeList(
               new CurrencyHundred()
               );
            var actual = CalculateChange.GetCorrectChange(cents, excludeList);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }

        }

        [TestMethod]
        public void GetCorrectChangeWithThirteenThousandSixHundredSixteenCents_ExcludeHundredAndTwentyTest()
        {
            var cents = 13616;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney {Name = denom.Name, PluralName = denom.PluralName};
                switch (denom.Name)
                {
                    case Enums.CurrencyType.Hundred:
                        break;
                    case Enums.CurrencyType.Twenty:
                        break;
                    case Enums.CurrencyType.Ten:
                        tillMoney.Val = 13;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Five:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.One:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Dime:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Nickel:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Penny:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                }
            }
            var expected = resultList;

            var excludeList = MoneyManager.CreateExcludeList(
                new CurrencyHundred(),
                new CurrencyTwenty()
                );
            var actual = CalculateChange.GetCorrectChange(cents, excludeList);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }

        }

        [TestMethod]
        public void GetCorrectChangeWithThirteenThousandSixHundredSixteenCents_ExcludeHundredAndTwentyAndTenTest()
        {
            var cents = 13616;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney {Name = denom.Name, PluralName = denom.PluralName};
                switch (denom.Name)
                {
                    case Enums.CurrencyType.Hundred:
                        break;
                    case Enums.CurrencyType.Twenty:
                        break;
                    case Enums.CurrencyType.Ten:
                        break;
                    case Enums.CurrencyType.Five:
                        tillMoney.Val = 27;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.One:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Dime:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Nickel:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Penny:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                }
            }
            var expected = resultList;

            var excludeList = MoneyManager.CreateExcludeList(
                new CurrencyHundred(),
                new CurrencyTwenty(),
                new CurrencyTen()
                );
            var actual = CalculateChange.GetCorrectChange(cents, excludeList);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }

        }

        [TestMethod]
        public void GetCorrectChangeWithThirteenThousandSixHundredSixteenCents_ExcludeHundredAndTwentyAndTenAndFiveTest()
        {
            var cents = 13616;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney {Name = denom.Name, PluralName = denom.PluralName};
                switch (denom.Name)
                {
                    case Enums.CurrencyType.Hundred:
                        break;
                    case Enums.CurrencyType.Twenty:
                        break;
                    case Enums.CurrencyType.Ten:
                        break;
                    case Enums.CurrencyType.Five:
                        break;
                    case Enums.CurrencyType.One:
                        tillMoney.Val = 136;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Dime:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Nickel:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Penny:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                }
            }
            var expected = resultList;

            var excludeList = MoneyManager.CreateExcludeList(
                new CurrencyHundred(),
                new CurrencyTwenty(),
                new CurrencyTen(),
                new CurrencyFive()
                );
            var actual = CalculateChange.GetCorrectChange(cents, excludeList);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }

        }

        [TestMethod]
        public void GetCorrectChangeWithThirteenThousandSixHundredSixteenCents_ExcludeHundredAndTwentyAndTenAndFiveAndOneTest()
        {
            var cents = 13616;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney {Name = denom.Name, PluralName = denom.PluralName};
                switch (denom.Name)
                {
                    case Enums.CurrencyType.Hundred:
                        break;
                    case Enums.CurrencyType.Twenty:
                        break;
                    case Enums.CurrencyType.Ten:
                        break;
                    case Enums.CurrencyType.Five:
                        break;
                    case Enums.CurrencyType.One:
                        break;
                    case Enums.CurrencyType.Dime:
                        tillMoney.Val = 1361;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Nickel:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                    case Enums.CurrencyType.Penny:
                        tillMoney.Val = 1;
                        resultList.Add(tillMoney);
                        break;
                }
            }
            var expected = resultList;

            var excludeList = MoneyManager.CreateExcludeList(
                new CurrencyHundred(),
                new CurrencyTwenty(),
                new CurrencyTen(),
                new CurrencyFive(),
                new CurrencyOne()
                );
            var actual = CalculateChange.GetCorrectChange(cents, excludeList);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }

        }

        [TestMethod]
        public void GetCorrectChangeWithThirteenThousandSixHundredSixteenCents_ExcludeHundredAndTwentyAndTenAndFiveAndOneAndDimeAndNickelTest()
        {
            var cents = 13616;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney {Name = denom.Name, PluralName = denom.PluralName};
                switch (denom.Name)
                {
                    case Enums.CurrencyType.Hundred:
                        break;
                    case Enums.CurrencyType.Twenty:
                        break;
                    case Enums.CurrencyType.Ten:
                        break;
                    case Enums.CurrencyType.Five:
                        break;
                    case Enums.CurrencyType.One:
                        break;
                    case Enums.CurrencyType.Dime:
                        break;
                    case Enums.CurrencyType.Nickel:
                        break;
                    case Enums.CurrencyType.Penny:
                        tillMoney.Val = 13616;
                        resultList.Add(tillMoney);
                        break;
                }
            }
            var expected = resultList;

            var excludeList = MoneyManager.CreateExcludeList(
                new CurrencyHundred(),
                new CurrencyTwenty(),
                new CurrencyTen(),
                new CurrencyFive(),
                new CurrencyOne(),
                new CurrencyDime(),
                new CurrencyNickel()
                );
            var actual = CalculateChange.GetCorrectChange(cents, excludeList);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }

        }







        [TestMethod]
        public void PullFromTillWithZeroCentsAndHundredTest()
        {
            const int cents = 0;
            const int denominationToPull = 10000;
            const int result = cents/denominationToPull;
            const int remainder = cents%denominationToPull;
            var expected = new TillResult
            {
                Result = result,
                Remainder = remainder,
            };

            var actual = CalculateChange.PullDenominationFromTill(cents, denominationToPull);

            Assert.AreEqual(expected.Result, actual.Result);
            Assert.AreEqual(expected.Remainder, actual.Remainder);
        }

        [TestMethod]
        public void PullFromTillWithZeroCentsAndPennyTest()
        {
            const int cents = 0;
            const int denominationToPull = 1;
            const int result = cents / denominationToPull;
            const int remainder = cents % denominationToPull;
            var expected = new TillResult
            {
                Result = result,
                Remainder = remainder,
            };

            var actual = CalculateChange.PullDenominationFromTill(cents, denominationToPull);

            Assert.AreEqual(expected.Result, actual.Result);
            Assert.AreEqual(expected.Remainder, actual.Remainder);
        }

        [TestMethod]
        public void PullFromTillWithHundredCentsAndHundredTest()
        {
            const int cents = 10000;
            const int denominationToPull = 10000;
            const int result = cents / denominationToPull;
            const int remainder = cents % denominationToPull;
            var expected = new TillResult
            {
                Result = result,
                Remainder = remainder,
            };

            var actual = CalculateChange.PullDenominationFromTill(cents, denominationToPull);

            Assert.AreEqual(expected.Result, actual.Result);
            Assert.AreEqual(expected.Remainder, actual.Remainder);
        }

        [TestMethod]
        public void PullFromTillWithFortyEightCentsAndDimeTest()
        {
            const int cents = 48;
            const int denominationToPull = 10;
            const int result = cents / denominationToPull;
            const int remainder = cents % denominationToPull;
            var expected = new TillResult
            {
                Result = result,
                Remainder = remainder,
            };

            var actual = CalculateChange.PullDenominationFromTill(cents, denominationToPull);

            Assert.AreEqual(expected.Result, actual.Result);
            Assert.AreEqual(expected.Remainder, actual.Remainder);
        }

    }
}
