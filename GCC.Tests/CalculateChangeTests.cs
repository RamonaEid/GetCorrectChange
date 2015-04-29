using System;
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
            decimal cents = .00M;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney { Name = denom.Name, PluralName = denom.PluralName };
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
            decimal cents = .48M;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney { Name = denom.Name, PluralName = denom.PluralName };
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
        public void GetCorrectChangeWithOneDollarAndFortyEightCents_EmptyExcludeListTest()
        {
            var cents = 1.48M;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney { Name = denom.Name, PluralName = denom.PluralName };
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
        public void GetCorrectChangeWithSixDollarsAndFortyEightCents_EmptyExcludeListTest()
        {
            var cents = 6.48M;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney { Name = denom.Name, PluralName = denom.PluralName };
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
        public void GetCorrectChangeWithSixteenDollarsAndFortyEightCents_EmptyExcludeListTest()
        {
            var cents = 16.48M;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney { Name = denom.Name, PluralName = denom.PluralName };
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
        public void GetCorrectChangeWithTwentySixDollarsAndFortyEightCents_EmptyExcludeListTest()
        {
            var cents = 26.48M;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney { Name = denom.Name, PluralName = denom.PluralName };
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
        public void GetCorrectChangeWithOneHundredSixDollarsAndFortyEightCents_EmptyExcludeListTest()
        {
            var cents = 106.48M;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney { Name = denom.Name, PluralName = denom.PluralName };
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
        public void GetCorrectChangeWithOneHundredThirtySixDollarsAndSixteenCents_EmptyExcludeListTest()
        {
            var cents = 136.16M;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney { Name = denom.Name, PluralName = denom.PluralName };
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
        public void GetCorrectChangeWithOneHundredThirtySixDollarsAndSixteenCents_ExcludeHundredTest()
        {
            var cents = 136.16M;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney { Name = denom.Name, PluralName = denom.PluralName };
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
        public void GetCorrectChangeWithOneHundredThirtySixDollarsAndSixteenCents_ExcludeHundredAndTwentyTest()
        {
            var cents = 136.16M;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney { Name = denom.Name, PluralName = denom.PluralName };
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
        public void GetCorrectChangeWithOneHundredThirtySixDollarsAndSixteenCents_ExcludeHundredAndTwentyAndTenTest()
        {
            var cents = 136.16M;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney { Name = denom.Name, PluralName = denom.PluralName };
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
        public void GetCorrectChangeWithOneHundredThirtySixDollarsAndixteenCents_ExcludeHundredAndTwentyAndTenAndFiveTest()
        {
            var cents = 136.16M;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney { Name = denom.Name, PluralName = denom.PluralName };
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
        public void GetCorrectChangeWithOneHundredThirtySixDollarsAndSixteenCents_ExcludeHundredAndTwentyAndTenAndFiveAndOneTest()
        {
            var cents = 136.16M;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney { Name = denom.Name, PluralName = denom.PluralName };
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
        public void GetCorrectChangeWithOneHundredThirtySixDollarsAndSixteenCents_ExcludeHundredAndTwentyAndTenAndFiveAndOneAndDimeAndNickelTest()
        {
            var cents = 136.16M;
            var resultList = new List<TillMoney>();
            var moneyList = _moneyList;
            foreach (var denom in moneyList)
            {
                var tillMoney = new TillMoney { Name = denom.Name, PluralName = denom.PluralName };
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
        [ExpectedException(typeof(DivideByZeroException))]
        public void PullFromTillWithZeroCentsAndZeroDenominationTest()
        {
            var cents = 0M;
            var denominationToPull = 0M;
            var result = decimal.Truncate(cents / denominationToPull);
            var remainder = cents % denominationToPull;
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
        public void PullFromTillWithZeroCentsAndHundredTest()
        {
            var cents = 0M;
            var denominationToPull = 100.00M;
            var result = decimal.Truncate(cents / denominationToPull);
            var remainder = cents % denominationToPull;
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
            decimal cents = 0M;
            decimal denominationToPull = .01M;
            decimal result = decimal.Truncate(cents / denominationToPull);
            decimal remainder = cents % denominationToPull;
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
            var cents = 100.00M;
            var denominationToPull = 100.00M;
            var result = decimal.Truncate(cents / denominationToPull);
            var remainder = cents % denominationToPull;
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
            var cents = .48M;
            var denominationToPull = .10M;
            var result = decimal.Truncate(cents / denominationToPull);
            var remainder = cents % denominationToPull;
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
