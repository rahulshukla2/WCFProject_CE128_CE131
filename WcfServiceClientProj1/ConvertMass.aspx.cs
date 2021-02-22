using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WcfServiceClientProj1
{
    public partial class ConvertMass : System.Web.UI.Page
    {
        ServiceReference1.ConverterServiceClient client;
        protected void Page_Load(object sender, EventArgs e)
        {
            client = new ServiceReference1.ConverterServiceClient();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            msg.Text = client.ConvertMass(ddlist1.SelectedIndex, ddlist2.SelectedIndex, Convert.ToDouble(mass.Text));
            msg.Visible = true;
        }
    }
}