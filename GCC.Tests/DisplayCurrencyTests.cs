using GCC.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GCC.Tests
{
    [TestClass]
    public class DisplayCurrencyTests
    {
        [TestMethod]
        public void GetPathnameOfCurrencyImageWithNullTest()
        {
            TillMoney tillMoney = null;
            var expected = "";

            var actual = DisplayCurrency.GetPathameOfCurrencyImage(tillMoney);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPathnameOfCurrencyImageWithHundredTest()
        {

            var denom = new CurrencyHundred();
            var tillMoney = new TillMoney
            {
                Name = denom.Name
            };
            var expected = "~/images/Hundred.png";

            var actual = DisplayCurrency.GetPathameOfCurrencyImage(tillMoney);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPathnameOfCurrencyImageWithHundredAndValsFromZeroToTenThousandTest()
        {
            var denom = new CurrencyHundred();
            for (int i = 0; i < 10001; i++)
            {
                var tillMoney = new TillMoney
                {
                    Name = denom.Name,
                    Val = i,
                    PluralName = denom.PluralName
                };
                var expected = i <= 4 ? "~/images/Hundred.png" : "~/images/Hundreds.png";

                var actual = DisplayCurrency.GetPathameOfCurrencyImage(tillMoney);

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void GetPathnameOfCurrencyImageWithTwentyTest()
        {
            var denom = new CurrencyTwenty();
            var tillMoney = new TillMoney
            {
                Name = denom.Name,
            };
            var expected = "~/images/Twenty.png";

            var actual = DisplayCurrency.GetPathameOfCurrencyImage(tillMoney);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPathnameOfCurrencyImageWithTwentyAndValsFromZeroToTenThousandTest()
        {
            var denom = new CurrencyTwenty();
            for (int i = 0; i < 10001; i++)
            {
                var tillMoney = new TillMoney
                {
                    Name = denom.Name,
                    Val = i,
                    PluralName = denom.PluralName
                };
                var expected = i <= 4 ? "~/images/Twenty.png" : "~/images/Twenties.png";

                var actual = DisplayCurrency.GetPathameOfCurrencyImage(tillMoney);

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void GetPathnameOfCurrencyImageWithTenTest()
        {
            var denom = new CurrencyTen();
            var tillMoney = new TillMoney
            {
                Name = denom.Name,
            };
            var expected = "~/images/Ten.png";

            var actual = DisplayCurrency.GetPathameOfCurrencyImage(tillMoney);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPathnameOfCurrencyImageWithTenAndValsFromZeroToTenThousandTest()
        {
            var denom = new CurrencyTen();
            for (int i = 0; i < 10001; i++)
            {
                var tillMoney = new TillMoney
                {
                    Name = denom.Name,
                    Val = i,
                    PluralName = denom.PluralName
                };
                var expected = i <= 4 ? "~/images/Ten.png" : "~/images/Tens.png";

                var actual = DisplayCurrency.GetPathameOfCurrencyImage(tillMoney);

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void GetPathnameOfCurrencyImageWithFiveTest()
        {
            var denom = new CurrencyFive();
            var tillMoney = new TillMoney
            {
                Name = denom.Name,
            };
            var expected = "~/images/Five.png";

            var actual = DisplayCurrency.GetPathameOfCurrencyImage(tillMoney);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPathnameOfCurrencyImageWithFiveAndValsFromZeroToTenThousandTest()
        {
            var denom = new CurrencyFive();
            for (int i = 0; i < 10001; i++)
            {
                var tillMoney = new TillMoney
                {
                    Name = denom.Name,
                    Val = i,
                    PluralName = denom.PluralName
                };
                var expected = i <= 4 ? "~/images/Five.png" : "~/images/Fives.png";

                var actual = DisplayCurrency.GetPathameOfCurrencyImage(tillMoney);

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void GetPathnameOfCurrencyImageWithOneTest()
        {
            var denom = new CurrencyOne();
            var tillMoney = new TillMoney
            {
                Name = denom.Name,
            };
            var expected = "~/images/One.png";

            var actual = DisplayCurrency.GetPathameOfCurrencyImage(tillMoney);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPathnameOfCurrencyImageWithOneAndValsFromZeroToTenThousandTest()
        {
            var denom = new CurrencyOne();
            for (int i = 0; i < 10001; i++)
            {
                var tillMoney = new TillMoney
                {
                    Name = denom.Name,
                    Val = i,
                    PluralName = denom.PluralName
                };
                var expected = i <= 4 ? "~/images/One.png" : "~/images/Ones.png";

                var actual = DisplayCurrency.GetPathameOfCurrencyImage(tillMoney);

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void GetPathnameOfCurrencyImageWithDimeTest()
        {
            var denom = new CurrencyDime();
            var tillMoney = new TillMoney
            {
                Name = denom.Name,
            };
            var expected = "~/images/Dime.png";

            var actual = DisplayCurrency.GetPathameOfCurrencyImage(tillMoney);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPathnameOfCurrencyImageWithDimeAndValsFromZeroToTenThousandTest()
        {
            var denom = new CurrencyDime();
            for (int i = 0; i < 10001; i++)
            {
                var tillMoney = new TillMoney
                {
                    Name = denom.Name,
                    Val = i,
                    PluralName = denom.PluralName
                };
                var expected = i <= 4 ? "~/images/Dime.png" : "~/images/Dimes.png";

                var actual = DisplayCurrency.GetPathameOfCurrencyImage(tillMoney);

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void GetPathnameOfCurrencyImageWithNickelTest()
        {
            var denom = new CurrencyNickel();
            var tillMoney = new TillMoney
            {
                Name = denom.Name,
            };
            var expected = "~/images/Nickel.png";

            var actual = DisplayCurrency.GetPathameOfCurrencyImage(tillMoney);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPathnameOfCurrencyImageWithNickelAndValsFromZeroToTenThousandTest()
        {
            var denom = new CurrencyNickel();
            for (int i = 0; i < 10001; i++)
            {
                var tillMoney = new TillMoney
                {
                    Name = denom.Name,
                    Val = i,
                    PluralName = denom.PluralName
                };
                var expected = i <= 4 ? "~/images/Nickel.png" : "~/images/Nickels.png";

                var actual = DisplayCurrency.GetPathameOfCurrencyImage(tillMoney);

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void GetPathnameOfCurrencyImageWithPennyTest()
        {
            var denom = new CurrencyPenny();
            var tillMoney = new TillMoney
            {
                Name = denom.Name,
            };
            var expected = "~/images/Penny.png";

            var actual = DisplayCurrency.GetPathameOfCurrencyImage(tillMoney);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPathnameOfCurrencyImageWithPennyAndValsFromZeroToTenThousandTest()
        {
            var denom = new CurrencyPenny();
            for (int i = 0; i < 10001; i++)
            {
                var tillMoney = new TillMoney
                {
                    Name = denom.Name,
                    Val = i,
                    PluralName = denom.PluralName
                };
                var expected = i <= 4 ? "~/images/Penny.png" : "~/images/Pennies.png";

                var actual = DisplayCurrency.GetPathameOfCurrencyImage(tillMoney);

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void GetNumberOfCurrencyImagesWithNegativeNumberTest()
        {
            var tillMoney = new TillMoney
            {
                Val = -1
            };
            var expected = 0;

            var actual = DisplayCurrency.GetNumberOfCurrencyImages(tillMoney);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetNumbeOfCurrencyImagesWithValFromZeroToTenThousandTest()
        {
            for (int i = 0; i < 10001; i++)
            {
                var tillMoney = new TillMoney
                {
                    Val = i
                };
                var expected = i;

                var actual = DisplayCurrency.GetNumberOfCurrencyImages(tillMoney);

                Assert.AreEqual(expected, actual);
            }
        }


    }
}
