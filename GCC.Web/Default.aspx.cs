using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

            var isSaleMoney = false;
            var isCashMoney = false;
            decimal sale;
            decimal cash;
            isSaleMoney = decimal.TryParse(saleAmount, out sale);
            isCashMoney = decimal.TryParse(cashTendered, out cash);

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
            else
            {
                resultLabel.Text = "Sale: " + sale + "<br/>Cash: " + cash + "<br/>Change: (coming soon)";
                resultLabel.CssClass = "text-success";
            }
        }
    }
}