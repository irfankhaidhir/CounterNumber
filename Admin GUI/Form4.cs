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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_MouseUp(object sender, MouseEventArgs e)
        {
            string URL = "https://optimal-disk-732.firebaseio.com/.json";
            var HTTPrequest = (HttpWebRequest)WebRequest.Create(URL);
            var Response = (HttpWebResponse)HTTPrequest.GetResponse();
            var StreamReader = new StreamReader(Response.GetResponseStream()).ReadToEnd();
            var Data = JObject.Parse(StreamReader);
            string Manual1 = Data["Manual1"].ToObject<string>();
            string Manual2 = Data["Manual2"].ToObject<string>();
            string Manual3 = Data["Manual3"].ToObject<string>();
            string Manual4 = Data["Manual4"].ToObject<string>();

            label14.Text = Manual1;
            label11.Text = Manual2;
            label12.Text = Manual3;
            label13.Text = Manual4;
        }
    }
}
