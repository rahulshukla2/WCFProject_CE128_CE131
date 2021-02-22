using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel.Description;
using System.ServiceModel;

namespace WcfServiceHostProj1
{
    public partial class Form1 : Form
    {
        ServiceHost sh = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Uri baseUrl = new Uri("http://localhost:8000/ConverterService");

            sh = new ServiceHost(typeof(WcfServiceLibraryProj1.ConverterService), baseUrl);

            sh.AddServiceEndpoint(typeof(WcfServiceLibraryProj1.IConverterService), new WSHttpBinding(),"");

            ServiceMetadataBehavior mbehave = new ServiceMetadataBehavior();
            mbehave.HttpGetEnabled = true;

            sh.Description.Behaviors.Add(mbehave);
            sh.Open();
            label1.Text = "Service is running";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sh.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
