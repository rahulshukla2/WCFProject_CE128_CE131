using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WcfServiceClientProj1
{
    public partial class CalcInterest : System.Web.UI.Page
    {
        ServiceReference1.ConverterServiceClient client;
        protected void Page_Load(object sender, EventArgs e)
        {
            client = new ServiceReference1.ConverterServiceClient();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            msg.Text = client.Calc_Interest(Convert.ToDouble(prinAmt.Text), Convert.ToDouble(rate.Text), Convert.ToDouble(years.Text), rdlist1.SelectedIndex);

            msg.Visible = true;
        }
    }
}