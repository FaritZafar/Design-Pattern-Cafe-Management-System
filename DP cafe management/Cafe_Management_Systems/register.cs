using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cafe_Management_Systems
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login f1 = new login();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Textbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = textBox1.Text;
            string pass =  textBox2.Text;
            StreamReader sr = new StreamReader("login.txt");
            string data = sr.ReadToEnd();
            sr.Close();
            if (data.Contains(uname))
            {
                MessageBox.Show("User already exist");
                textBox1.ResetText();
                textBox2.ResetText();
            }
            else
            {
                StreamWriter sw = new StreamWriter("login.txt", true);
                sw.WriteLine(uname + " " + pass);
                sw.Close();
                MessageBox.Show("User Registered");
            }
        }
    }
    }

