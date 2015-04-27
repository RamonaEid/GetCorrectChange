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
        private List<ICurrency> _excludedList = new List<ICurrency>();

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
                resultLabel.Text = "Excuse me, but you haven't given me enough money to cover the sale.";
                resultLabel.CssClass = "text-danger";
                ClearMoneyLabelsAndImages();
            }
            else
            {
                var curChange = (cash - sale);

                //var excludeList = MoneyManager.CreateExcludeList();
                _excludedList = GetExludedList();
                var excludeList = MoneyManager.CreateExcludeList(_excludedList.ToArray());
                var change = CalculateChange.GetCorrectChange(curChange, excludeList);

                resultLabel.Text = String.Format("Change: {0:C}", (sale - cash));
                resultLabel.CssClass = "text-success";

                //ShowNotInTillDisplay(_excludedList);
                SetDisplay(change, excludeList);
            }

        }

        private void ClearMoneyLabelsAndImages()
        {
            const string text = "";
            const string css = "";
            const string url = "";

            labelHundred.Text = text;
            labelHundred.CssClass = css;
            imgHundred.ImageUrl = url;

            labelTwenty.Text = text;
            labelTwenty.CssClass = css;
            imgTwenty.ImageUrl = url;

            labelTen.Text = text;
            labelTen.CssClass = css;
            imgTen.ImageUrl = url;

            labelFive.Text = text;
            labelFive.CssClass = css;
            imgFive.ImageUrl = url;

            labelOne.Text = text;
            labelOne.CssClass = css;
            imgOne.ImageUrl = url;

            labelDime.Text = text;
            labelDime.CssClass = css;
            imgDime.ImageUrl = url;

            labelNickel.Text = text;
            labelNickel.CssClass = css;
            imgNickel.ImageUrl = url;

            labelPenny.Text = text;
            labelPenny.CssClass = css;
            imgPenny.ImageUrl = url;
        }


        private List<ICurrency> GetExludedList()
        {
            foreach (ListItem item in excludeCheckBoxList.Items)
            {
                if (item.Selected)
                {
                    switch (item.Value)
                    {
                        case "Hundred":
                            _excludedList.Add(new CurrencyHundred());
                            break;
                        case "Twenty":
                            _excludedList.Add(new CurrencyTwenty());
                            break;
                        case "Ten":
                            _excludedList.Add(new CurrencyTen());
                            break;
                        case "Five":
                            _excludedList.Add(new CurrencyFive());
                            break;
                        case "One":
                            _excludedList.Add(new CurrencyOne());
                            break;
                        case "Dime":
                            _excludedList.Add(new CurrencyDime());
                            break;
                        case "Nickel":
                            _excludedList.Add(new CurrencyNickel());
                            break;
                        case "Penny":
                            _excludedList.Add(new CurrencyPenny());
                            break;
                    }
                }
            }

            return _excludedList;
        }


        private void SetDisplay(List<TillMoney> change, List<ICurrency> excludedList)
        {
            var cssClass = "text-success";

            foreach (var denom in change)
            {
                switch (denom.Name)
                {
                    case Enums.CurrencyType.Hundred:
                        labelHundred.Text = FormatLabel(denom);
                        labelHundred.CssClass = cssClass;
                        imgHundred.ImageUrl = FormatImage(denom);
                        break;
                    case Enums.CurrencyType.Twenty:
                        labelTwenty.Text = FormatLabel(denom);
                        labelTwenty.CssClass = cssClass;
                        imgTwenty.ImageUrl = FormatImage(denom);
                        break;
                    case Enums.CurrencyType.Ten:
                        labelTen.Text = FormatLabel(denom);
                        labelTen.CssClass = cssClass;
                        imgTen.ImageUrl = FormatImage(denom);
                        break;
                    case Enums.CurrencyType.Five:
                        labelFive.Text = FormatLabel(denom);
                        labelFive.CssClass = cssClass;
                        imgFive.ImageUrl = FormatImage(denom);
                        break;
                    case Enums.CurrencyType.One:
                        labelOne.Text = FormatLabel(denom);
                        labelOne.CssClass = cssClass;
                        imgOne.ImageUrl = FormatImage(denom);
                        break;
                    case Enums.CurrencyType.Dime:
                        labelDime.Text = FormatLabel(denom);
                        labelDime.CssClass = cssClass;
                        imgDime.ImageUrl = FormatImage(denom);
                        break;
                    case Enums.CurrencyType.Nickel:
                        labelNickel.Text = FormatLabel(denom);
                        labelNickel.CssClass = cssClass;
                        imgNickel.ImageUrl = FormatImage(denom);
                        break;
                    case Enums.CurrencyType.Penny:
                        labelPenny.Text = FormatLabel(denom);
                        labelPenny.CssClass = cssClass;
                        imgPenny.ImageUrl = FormatImage(denom);
                        break;
                }
            }

            SetExcludedDisplay(excludedList);
        }

        private void SetExcludedDisplay(List<ICurrency> excludedList)
        {
            const string text = "NOT IN TILL";
            const string cssClass = "text-danger";
            const string url = "";

            foreach (var denom in excludedList)
            {
                switch (denom.Name)
                {
                    case Enums.CurrencyType.Hundred:
                        labelHundred.Text = text;
                        labelHundred.CssClass = cssClass;
                        imgHundred.ImageUrl = url;
                        break;
                    case Enums.CurrencyType.Twenty:
                        labelTwenty.Text = text;
                        labelTwenty.CssClass = cssClass;
                        imgTwenty.ImageUrl = url;
                        break;
                    case Enums.CurrencyType.Ten:
                        labelTen.Text = text;
                        labelTen.CssClass = cssClass;
                        imgTen.ImageUrl = url;
                        break;
                    case Enums.CurrencyType.Five:
                        labelFive.Text = text;
                        labelFive.CssClass = cssClass;
                        imgFive.ImageUrl = url;
                        break;
                    case Enums.CurrencyType.One:
                        labelOne.Text = text;
                        labelOne.CssClass = cssClass;
                        imgOne.ImageUrl = url;
                        break;
                    case Enums.CurrencyType.Dime:
                        labelDime.Text = text;
                        labelDime.CssClass = cssClass;
                        imgDime.ImageUrl = url;
                        break;
                    case Enums.CurrencyType.Nickel:
                        labelNickel.Text = text;
                        labelNickel.CssClass = cssClass;
                        imgNickel.ImageUrl = url;
                        break;
                    case Enums.CurrencyType.Penny:
                        labelPenny.Text = text;
                        labelPenny.CssClass = cssClass;
                        imgPenny.ImageUrl = url;
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