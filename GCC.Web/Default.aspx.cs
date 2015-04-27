using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GCC.BL;
using Microsoft.Ajax.Utilities;

namespace GCC.Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void getChangeButton_Click(object sender, EventArgs e)
        {
            Process();
        }

        private void Process()
        {
            //TODO: refactor all of this
            var saleAmount = saleTextBox.Text;
            var cashTendered = cashTextBox.Text;

            decimal sale;
            decimal cash;
            var isSaleMoney = decimal.TryParse(saleAmount, out sale);
            var isCashMoney = decimal.TryParse(cashTendered, out cash);

            if (!(isSaleMoney && isCashMoney))
            {
                resultLabel.Text =
                    "AmountOfSale and CustomerGaveMe are both required. \r\nYou must enter dollars AND cents including the dot.";
                resultLabel.CssClass = "text-danger";
            }
            else if (sale > 500.00M)
            {
                resultLabel.Text = sale + " as Amount of Sale is OVER 500.00.";
                resultLabel.CssClass = "text-danger";
                saleTextBox.Text = "";
            }
            else if (cash < sale)
            {
                resultLabel.Text = "Excuse me, but you haven't given me money to cover the sale.";
                resultLabel.CssClass = "text-danger";
            }
            else
            {
                var curChange = (cash - sale);
                var excludeList = MoneyManager.CreateExcludeList();
                var change = CalculateChange.GetCorrectChange(curChange, excludeList);

                resultLabel.Text = String.Format("Change: {0:C}", (sale-cash));

                resultLabel.CssClass = "text-success";
                SetDisplay(change);
            }

        }

        private void SetDisplay(List<TillMoney> change)
        {
            foreach (var denom in change)
            {
                switch (denom.Name)
                {
                    case Enums.CurrencyType.Hundred:
                        labelHundred.Text = FormatLabel(denom);
                        imgHundred.ImageUrl = FormatImage(denom);
                        break;
                    case Enums.CurrencyType.Twenty:
                        labelTwenty.Text = FormatLabel(denom);
                        imgTwenty.ImageUrl = FormatImage(denom);
                        break;
                    case Enums.CurrencyType.Ten:
                        labelTen.Text = FormatLabel(denom);
                        imgTen.ImageUrl = FormatImage(denom);
                        break;
                    case Enums.CurrencyType.Five:
                        labelFive.Text = FormatLabel(denom);
                        imgFive.ImageUrl = FormatImage(denom);
                        break;
                    case Enums.CurrencyType.One:
                        labelOne.Text = FormatLabel(denom);
                        imgOne.ImageUrl = FormatImage(denom);
                        break;
                    case Enums.CurrencyType.Dime:
                        labelDime.Text = FormatLabel(denom);
                        imgDime.ImageUrl = FormatImage(denom);
                        break;
                    case Enums.CurrencyType.Nickel:
                        labelNickel.Text = FormatLabel(denom);
                        imgNickel.ImageUrl = FormatImage(denom);
                        break;
                    case Enums.CurrencyType.Penny:
                        labelPenny.Text = FormatLabel(denom);
                        imgPenny.ImageUrl = FormatImage(denom);
                        break;
                }
            }
        }

        private string FormatLabel(TillMoney denom)
        {
            var result = denom.Val == 1 ? String.Format("{0} {1}", denom.Val, denom.Name) : String.Format("{0} {1}", denom.Val, denom.PluralName);

            return result;
        }

        private string FormatImage(TillMoney denom)
        {
            var result = "";
            if (denom.Val == 0) return result;
            result = DisplayCurrency.GetPathameOfCurrencyImage(denom);
            return result;
        }
    }
}