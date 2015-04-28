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
            var saleAmount = saleTextBox.Text;
            var cashTendered = cashTextBox.Text;

            decimal sale;
            decimal cash;
            var isSaleMoney = decimal.TryParse(saleAmount, out sale);
            var isCashMoney = decimal.TryParse(cashTendered, out cash);

            var msg = "";
            var cssClass = "";
            if (!(isSaleMoney && isCashMoney))
            {
                msg = "AmountOfSale and CustomerGaveMe are both required. \r\nYou must enter dollars AND cents including the dot.";
                cssClass = "text-danger";
                FormatResultLabel(msg, cssClass);
            }
            else if (sale > 500.00M)
            {
                msg = sale + " as Amount of Sale is OVER 500.00.";
                cssClass = "text-danger";
                FormatResultLabel(msg, cssClass);
                saleTextBox.Text = "";
            }
            else if (cash < sale)
            {
                msg = "Excuse me, but you haven't given me enough money to cover the sale.";
                cssClass = "text-danger";
                FormatResultLabel(msg, cssClass);
                ClearMoneyLabelsAndImages();
            }
            else
            {
                var curChange = (cash - sale);

                _excludedList = GetExludedList();
                var excludeList = MoneyManager.CreateExcludeList(_excludedList.ToArray());
                var change = CalculateChange.GetCorrectChange(curChange, excludeList);

                resultLabel.Text = String.Format("Change: {0:C}", (sale - cash));
                resultLabel.CssClass = "text-success";

                SetMoneyDisplay(change, excludeList);
            }

        }

        private void FormatResultLabel(string msg, string cssClass)
        {
            resultLabel.Text = msg;
            resultLabel.CssClass = cssClass;
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


        private void SetMoneyDisplay(List<TillMoney> change, List<ICurrency> excludedList)
        {
            var cssClass = "text-success";

            foreach (var denom in change)
            {
                switch (denom.Name)
                {
                    case Enums.CurrencyType.Hundred:
                        labelHundred.Text = FormatMoneyLabel(denom);
                        labelHundred.CssClass = cssClass;
                        imgHundred.ImageUrl = FormatMoneyImage(denom);
                        break;
                    case Enums.CurrencyType.Twenty:
                        labelTwenty.Text = FormatMoneyLabel(denom);
                        labelTwenty.CssClass = cssClass;
                        imgTwenty.ImageUrl = FormatMoneyImage(denom);
                        break;
                    case Enums.CurrencyType.Ten:
                        labelTen.Text = FormatMoneyLabel(denom);
                        labelTen.CssClass = cssClass;
                        imgTen.ImageUrl = FormatMoneyImage(denom);
                        break;
                    case Enums.CurrencyType.Five:
                        labelFive.Text = FormatMoneyLabel(denom);
                        labelFive.CssClass = cssClass;
                        imgFive.ImageUrl = FormatMoneyImage(denom);
                        break;
                    case Enums.CurrencyType.One:
                        labelOne.Text = FormatMoneyLabel(denom);
                        labelOne.CssClass = cssClass;
                        imgOne.ImageUrl = FormatMoneyImage(denom);
                        break;
                    case Enums.CurrencyType.Dime:
                        labelDime.Text = FormatMoneyLabel(denom);
                        labelDime.CssClass = cssClass;
                        imgDime.ImageUrl = FormatMoneyImage(denom);
                        break;
                    case Enums.CurrencyType.Nickel:
                        labelNickel.Text = FormatMoneyLabel(denom);
                        labelNickel.CssClass = cssClass;
                        imgNickel.ImageUrl = FormatMoneyImage(denom);
                        break;
                    case Enums.CurrencyType.Penny:
                        labelPenny.Text = FormatMoneyLabel(denom);
                        labelPenny.CssClass = cssClass;
                        imgPenny.ImageUrl = FormatMoneyImage(denom);
                        break;
                }
            }

            SetExcludedMoneyDisplay(excludedList);
        }

        private void SetExcludedMoneyDisplay(List<ICurrency> excludedList)
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

        private string FormatMoneyLabel(TillMoney denom)
        {
            var result = denom.Val == 1 ? String.Format("{0} {1}", denom.Val, denom.Name) : String.Format("{0} {1}", denom.Val, denom.PluralName);

            return result;
        }

        private string FormatMoneyImage(TillMoney denom)
        {
            var result = "";
            if (denom.Val == 0) return result;
            result = DisplayCurrency.GetPathameOfCurrencyImage(denom);
            return result;
        }


    }
}