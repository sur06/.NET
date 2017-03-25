using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Author @ Abhijith

namespace csharpRestClient1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        #region UI Event Handlers

        private void cmdGO_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();
            rClient.endpoint = txtRequestURI.Text;

            debugOutput("Rest Client Created");

            string strResponse = string.Empty;

            strResponse = rClient.makeRequest();

            debugOutput(strResponse);


        }
        #endregion
        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }
    }

}
