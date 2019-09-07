using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Firebase_Updated_Data_Specific
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            while (true)
            {
                string URL = "https://optimal-disk-732.firebaseio.com/.json";
                var HTTPrequest = (HttpWebRequest)WebRequest.Create(URL);
                var Response = (HttpWebResponse)HTTPrequest.GetResponse();
                var StreamReader = new StreamReader(Response.GetResponseStream()).ReadToEnd();
                var Data = JObject.Parse(StreamReader);
                string Counter1 = Data["Current1"].ToObject<string>();
                string Counter2 = Data["Current2"].ToObject<string>();
                string Counter3 = Data["Current3"].ToObject<string>();
                string Counter4 = Data["Current4"].ToObject<string>();

                Console.WriteLine("Counter 1=" + Counter1);
                Console.WriteLine("Counter 2=" + Counter2);
                Console.WriteLine("Counter 3=" + Counter3);
                Console.WriteLine("Counter 4=" + Counter4);






            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            string URL = "https://optimal-disk-732.firebaseio.com/.json";
            var HTTPrequest = (HttpWebRequest)WebRequest.Create(URL);
            var Response = (HttpWebResponse)HTTPrequest.GetResponse();
            var StreamReader = new StreamReader(Response.GetResponseStream()).ReadToEnd();
            var Data = JObject.Parse(StreamReader);
            string Button1 = Data["Number1"].ToObject<string>();
            string Button1end = Button1 + 1;
            MessageBox.Show("Your queue number is:" + Button1end);

        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            string URL = "https://optimal-disk-732.firebaseio.com/.json";
            var HTTPrequest = (HttpWebRequest)WebRequest.Create(URL);
            var Response = (HttpWebResponse)HTTPrequest.GetResponse();
            var StreamReader = new StreamReader(Response.GetResponseStream()).ReadToEnd();
            var Data = JObject.Parse(StreamReader);
            string Button2 = Data["Number2"].ToObject<string>();
            string Button2end = Button2 + 1;
            MessageBox.Show("Your queue number is:" + Button2end);
        }

        private async void Button3_Click(object sender, EventArgs e)
        {
            string URL = "https://optimal-disk-732.firebaseio.com/.json";
            var HTTPrequest = (HttpWebRequest)WebRequest.Create(URL);
            var Response = (HttpWebResponse)HTTPrequest.GetResponse();
            var StreamReader = new StreamReader(Response.GetResponseStream()).ReadToEnd();
            var Data = JObject.Parse(StreamReader);
            string Button3 = Data["Number3"].ToObject<string>();
            string Button3end = Button3 + 1;
            MessageBox.Show("Your queue number is:" + Button3end);
        }

        private async void Button4_Click(object sender, EventArgs e)
        {
            string URL = "https://optimal-disk-732.firebaseio.com/.json";
            var HTTPrequest = (HttpWebRequest)WebRequest.Create(URL);
            var Response = (HttpWebResponse)HTTPrequest.GetResponse();
            var StreamReader = new StreamReader(Response.GetResponseStream()).ReadToEnd();
            var Data = JObject.Parse(StreamReader);
            string Button4 = Data["Number4"].ToObject<string>();
            string Button4end = Button4 + 1;
            MessageBox.Show("Your queue number is:" + Button4end);
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
