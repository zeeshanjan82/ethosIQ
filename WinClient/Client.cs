using ClientProxy;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using TransferObjects;

namespace WinClient
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text;

            WebClient client = new WebClient();

            Task<object> task = client.GetRequest(url);

            task.Wait();

            object result = task.Result;

            if (rbWHO.Checked && cbEntity.SelectedItem == "Country") {

                WHO_GHOCountryDTO country = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<WHO_GHOCountryDTO>(result.ToString());

                lblResult.Text = country.copyright;
            }
            else if (rbHC.Checked && cbEntity.SelectedItem == "Grossary")
            {
                HC_GrossaryDTO index = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<HC_GrossaryDTO>(result.ToString());

                lblResult.Text = index.glossary[0].id;
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            if (rbWHO.Checked)
            {
                cbEntity.Items.Clear();
                cbEntity.Items.Add("Country");
            }
            else {
                cbEntity.Items.Clear();
                cbEntity.Items.Add("Grossary");
            }
        }

        private void rbHC_CheckedChanged(object sender, EventArgs e)
        {

            cbEntity.Items.Clear();
            cbEntity.Items.Add("Grossary");
        }

        private void rbWHO_CheckedChanged(object sender, EventArgs e)
        {
            cbEntity.Items.Clear();
            cbEntity.Items.Add("Country");
        }
    }
}
