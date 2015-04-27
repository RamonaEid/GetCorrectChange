using System.Collections.Generic;
using System.Linq;
using GCC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GCC.Tests
{
    [TestClass]
    public class ManageMoneyTests
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
        public void CreateMoneyList()
        {
            // Arrange
            var expected = _moneyList;

            // Act
            var actual = MoneyManager.CreateMoneyList();

            // Assert
            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }

        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void CreateExcludeListAndParamsNullTest()
        {
            ICurrency[] excludedArray = null;
            var expected = excludedArray.Length;

            var actual = MoneyManager.CreateExcludeList(excludedArray);

            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        public void CreateExcludeListAndParamsEmptyTest()
        {
            var excludedArray = new ICurrency[] {};
            var expected = excludedArray;

            var actual = MoneyManager.CreateExcludeList(excludedArray);

            Assert.AreEqual(expected.Length, actual.Count);
        }

        [TestMethod]
        public void CreateExcludeListAndParamsHundredTest()
        {
            var excludedArray = new ICurrency[] { new CurrencyHundred()};
            var expected = excludedArray.ToList();

            var actual = MoneyManager.CreateExcludeList(excludedArray);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }
            
        }

        [TestMethod]
        public void CreateExcludeListAndParamsHundredsAndTwentiesTest()
        {
            var excludedArray = new ICurrency[]
            {
                new CurrencyHundred(), 
                new CurrencyTwenty()
            };
            var expected = excludedArray.ToList();

            var actual = MoneyManager.CreateExcludeList(excludedArray);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }

        }

        [TestMethod]
        public void CreateExcludeListAndParamsHundredsAndTwentiesAndDimesTest()
        {
            var excludedArray = new ICurrency[]
            {
                new CurrencyHundred(),
                new CurrencyTwenty(),
                new CurrencyDime()
            };
            var expected = excludedArray.ToList();

            var actual = MoneyManager.CreateExcludeList(excludedArray);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }
            
        }

        [TestMethod]
        public void CreateTypesOfMoneyInTillListAndExcludeNullTest()
        {
            var expected = _moneyList;

            List<ICurrency> excludeList = null;
            var actual = MoneyManager.CreateTypesOfMoneyInTillList(excludeList);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }
            
        }

        [TestMethod]
        public void CreateTypesOfMoneyInTillListAndExcludeEmptyTest()
        {
            var expected = _moneyList;

            var excludeList =MoneyManager.CreateExcludeList();
            var actual = MoneyManager.CreateTypesOfMoneyInTillList(excludeList);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }
            
        }

        [TestMethod]
        public void CreateTypesOfMoneyInTillListAndExcludeHundredsTest()
        {
            var expected = _moneyList;
            expected.Remove(expected.Find(x => x.Name == Enums.CurrencyType.Hundred));

            var excludeList = MoneyManager.CreateExcludeList(new CurrencyHundred());
            var actual = MoneyManager.CreateTypesOfMoneyInTillList(excludeList);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }
            
        }

        [TestMethod]
        public void CreateTypesOfMoneyInTillListAndExcludeTwentiesTest()
        {
            var expected = _moneyList;
            expected.Remove(expected.Find(x => x.Name == Enums.CurrencyType.Twenty));

            var excludeList = MoneyManager.CreateExcludeList(new CurrencyTwenty());
            var actual = MoneyManager.CreateTypesOfMoneyInTillList(excludeList);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }
            
        }

        [TestMethod]
        public void CreateTypesOfMoneyInTillListAndExcludeTensTest()
        {
            var expected = _moneyList;
            expected.Remove(expected.Find(x => x.Name == Enums.CurrencyType.Ten));

            var excludeList = MoneyManager.CreateExcludeList(new CurrencyTen());
            var actual = MoneyManager.CreateTypesOfMoneyInTillList(excludeList);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }
            
        }

        [TestMethod]
        public void CreateTypesOfMoneyInTillListAndExcludeFivesTest()
        {
            var expected = _moneyList;
            expected.Remove(expected.Find(x => x.Name == Enums.CurrencyType.Five));

            var excludeList = MoneyManager.CreateExcludeList(new CurrencyFive());
            var actual = MoneyManager.CreateTypesOfMoneyInTillList(excludeList);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }
            
        }

        [TestMethod]
        public void CreateTypesOfMoneyInTillListAndExcludeOnesTest()
        {
            var expected = _moneyList;
            expected.Remove(expected.Find(x => x.Name == Enums.CurrencyType.One));

            var excludeList = MoneyManager.CreateExcludeList(new CurrencyOne());
            var actual = MoneyManager.CreateTypesOfMoneyInTillList(excludeList);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }
            
        }

        [TestMethod]
        public void CreateTypesOfMoneyInTillListAndExcludeDimesTest()
        {
            var expected = _moneyList;
            expected.Remove(expected.Find(x => x.Name == Enums.CurrencyType.Dime));

            var excludeList = MoneyManager.CreateExcludeList(new CurrencyDime());
            var actual = MoneyManager.CreateTypesOfMoneyInTillList(excludeList);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }
            
        }

        [TestMethod]
        public void CreateTypesOfMoneyInTillListAndExcludeNickelsTest()
        {
            var expected = _moneyList;
            expected.Remove(expected.Find(x => x.Name == Enums.CurrencyType.Nickel));

            var excludeList = MoneyManager.CreateExcludeList(new CurrencyNickel());
            var actual = MoneyManager.CreateTypesOfMoneyInTillList(excludeList);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }
            
        }

        [TestMethod]
        public void CreateTypesOfMoneyInTillListAndExcludeHundredsAndTwenties()
        {
            var expected = _moneyList;
            expected.Remove(expected.Find(x => x.Name == Enums.CurrencyType.Hundred));
            expected.Remove(expected.Find(x => x.Name == Enums.CurrencyType.Twenty));

            var excludeList = MoneyManager.CreateExcludeList(
                new CurrencyHundred(),
                new CurrencyTwenty()
                );
            var actual = MoneyManager.CreateTypesOfMoneyInTillList(excludeList);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }
            
        }

        [TestMethod]
        public void CreateTypesOfMoneyInTillListAndExcludeHundredsAndTensAndDimes()
        {
            var expected = _moneyList;
            expected.Remove(expected.Find(x => x.Name == Enums.CurrencyType.Hundred));
            expected.Remove(expected.Find(x => x.Name == Enums.CurrencyType.Ten));
            expected.Remove(expected.Find(x => x.Name == Enums.CurrencyType.Dime));

            var excludeList = MoneyManager.CreateExcludeList(
                new CurrencyHundred(),
                new CurrencyTen(),
                new CurrencyDime()
                );
            var actual = MoneyManager.CreateTypesOfMoneyInTillList(excludeList);

            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i].Name, actual[i].Name);
                Assert.AreEqual(expected[i].Val, actual[i].Val);
                Assert.AreEqual(expected[i].PluralName, actual[i].PluralName);
            }
            
        }

    }
}
