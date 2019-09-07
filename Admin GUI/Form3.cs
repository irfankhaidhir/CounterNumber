using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Net;
using System.IO;

namespace Admin_GUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            string URL = "https://optimal-disk-732.firebaseio.com/.json";
            var HTTPrequest = (HttpWebRequest)WebRequest.Create(URL);
            var Response = (HttpWebResponse)HTTPrequest.GetResponse();
            var StreamReader = new StreamReader(Response.GetResponseStream()).ReadToEnd();
            var Data = JObject.Parse(StreamReader);
            string Number1 = Data["Number1"].ToObject<string>();
            string Number2 = Data["Number2"].ToObject<string>();
            string Number3 = Data["Number3"].ToObject<string>();
            string Number4 = Data["Number4"].ToObject<string>();

            label14.Text = Number1;
            label11.Text = Number2;
            label12.Text = Number3;
            label13.Text = Number4;

        }
    }
}
