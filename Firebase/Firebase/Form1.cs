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
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json.Linq;

namespace Firebase
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "M4kcQKLjnCn4rUUpjdOKhWX9zw7UuWq1zMs3GyTx",
            BasePath = "https://optimal-disk-732.firebaseio.com/"
        };


        IFirebaseClient client;
        int Button1end;
        int Button2end = 1000;
        int Button3end = 2000;
        int Button4end = 3000;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if(client!=null)
            {
                MessageBox.Show("Connection is established");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private async void Button1_Click(object sender, EventArgs e)
        {
  
        }

        private async void Button2_Click(object sender, EventArgs e)
        {

        }

        private async void Button3_Click(object sender, EventArgs e)
        {
            int x = 1;
            Button1end = Button1end + x;
            var data = new Data
            {
                Manual1 = Button1end
            };
            MessageBox.Show("Your queue number is:" + Button1end);
            SetResponse response = await client.SetTaskAsync("", data);
            Data result = response.ResultAs<Data>();

        }

        private async void Button4_Click(object sender, EventArgs e)
        {
            int x = 1;
            Button2end = Button2end + x;
            var data = new Data
            {
                Manual2 = Button2end
            };
            MessageBox.Show("Your queue number is:" + Button2end);
            SetResponse response = await client.SetTaskAsync("", data);
            Data result = response.ResultAs<Data>();
        }

        private async void Button5_Click(object sender, EventArgs e)
        {
            int x = 1;
            Button3end = Button3end + x;
            var data = new Data
            {
                Manual3 = Button3end
            };
            MessageBox.Show("Your queue number is:" + Button3end);
            SetResponse response = await client.SetTaskAsync("", data);
            Data result = response.ResultAs<Data>();
        }

        private async void Button6_Click(object sender, EventArgs e)
        {
            int x = 1;
            Button4end = Button4end + x;
            var data = new Data
            {
                Manual4 = Button4end
            };
            MessageBox.Show("Your queue number is:" + Button4end);
            SetResponse response = await client.SetTaskAsync("", data);
            Data result = response.ResultAs<Data>();
        }
    }
}
