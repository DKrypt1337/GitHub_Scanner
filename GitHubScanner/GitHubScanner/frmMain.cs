using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GitHubScanner
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string URL = "https://api.github.com/search/users?q=" + txt_SearchTerm.Text;
            string urlParameters = "";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Clear();

            client.DefaultRequestHeaders.Add("Accept", "*/*");
            client.DefaultRequestHeaders.Add("User-Agent", "Thunder Client");


            HttpResponseMessage response = client.GetAsync(urlParameters).Result;
            if (response.IsSuccessStatusCode)
            {
                try
                {
                    string tmpResponse = response.Content.ReadAsStringAsync().Result;
                    Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(tmpResponse);
                    txtData.Text = "";
                    txtData.Text += myDeserializedClass.items[0].login;
                    for (int i = 1; i < myDeserializedClass.items.Count; i++)
                    {
                        txtData.Text += Environment.NewLine;
                        txtData.Text += myDeserializedClass.items[i].login;
                    }
                }
                catch(Exception ex)
                {
                    txtData.Text += ex.Message;
                }
            }
            else
            {
                txtData.Text += (int)response.StatusCode + " - " + response.ReasonPhrase;
            }


            // Make any other calls using HttpClient here.

            // Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
             client.Dispose();
        }
    }
}
