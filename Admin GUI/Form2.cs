using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Net;
using System.IO;

namespace Admin_GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
 
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Label14_TextChanged(object sender, EventArgs e)
        {
            
            for (int i =0; i<100; i++) 
            {
                string app;
            }
        }

        private void Form2_MouseHover(object sender, EventArgs e)
        {

        }

        private void Form2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Form2_Activated(object sender, EventArgs e)
        {
           
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
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
                string TotalForm = Data["TotalForm"].ToObject<string>();
                string TotalCanceled = Data["TotalCanceled"].ToObject<string>();

                label3.Text = TotalCanceled;
                label5.Text = TotalForm;

     
          


        }

            private void Button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Label20_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string URL = "https://optimal-disk-732.firebaseio.com/.json";
            var HTTPrequest = (HttpWebRequest)WebRequest.Create(URL);
            var Response = (HttpWebResponse)HTTPrequest.GetResponse();
            var StreamReader = new StreamReader(Response.GetResponseStream()).ReadToEnd();
            var Data = JObject.Parse(StreamReader);
            string Name = Data["Name"].ToObject<string>();
            string IC = Data["IC"].ToObject<string>();
            string Phonenumber = Data["Phone number"].ToObject<string>();

            MessageBox.Show("Name = " + Name + "\n IC = " + IC + "\n Phone number" + Phonenumber);

            


        }

        private void Label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string URL = "https://optimal-disk-732.firebaseio.com/.json";
            var HTTPrequest = (HttpWebRequest)WebRequest.Create(URL);
            var Response = (HttpWebResponse)HTTPrequest.GetResponse();
            var StreamReader = new StreamReader(Response.GetResponseStream()).ReadToEnd();
            foreach (var number in StreamReader.Distinct()) ;
            var Data = JObject.Parse(StreamReader);
            string Cancel1 = Data["Cancel1"].ToObject<string>();
            string Cancel2 = Data["Cancel2"].ToObject<string>();
            string Cancel3 = Data["Cancel3"].ToObject<string>();
            string Cancel4 = Data["Cancel4"].ToObject<string>();
            MessageBox.Show("Counter 1 =" + Cancel1 + "\n Counter 2 = " + Cancel2 + "\n Counter 3 = " + Cancel3 + "\n Counter 4 = " + Cancel4);
        }
    }
}
