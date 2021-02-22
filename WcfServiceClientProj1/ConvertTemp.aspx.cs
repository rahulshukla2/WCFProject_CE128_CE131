using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WcfServiceClientProj1
{
    public partial class ConvertTemp : System.Web.UI.Page
    {
        ServiceReference1.ConverterServiceClient client;
        protected void Page_Load(object sender, EventArgs e)
        {
            client = new ServiceReference1.ConverterServiceClient();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            msg.Text = client.ConvertTemperature(ddlist1.SelectedIndex, ddlist2.SelectedIndex , Convert.ToDouble(temp.Text));
            msg.Visible = true;
        }
    }
}