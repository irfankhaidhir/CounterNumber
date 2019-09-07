using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = "AE150046";
            string password = "1234";

            if (username == textBox1.Text && password == textBox2.Text)
            {

                MessageBox.Show("Access granted");
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }

               

                else
                {
                    MessageBox.Show("Access denied");
                }
              
                
          

        }

    }
}

