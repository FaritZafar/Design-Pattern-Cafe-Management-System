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
using Bunifu.Framework.UI;


namespace Cafe_Management_Systems
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySingleton Mysingle = MySingleton.Instance;
            Mysingle.loginLogic(Textbox1,Textbox2);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register reg = new register();
            reg.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Textbox2_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
    public class MySingleton
    {

        private static MySingleton instance = null;
        private MySingleton() {}
        private static readonly object padlock = new object();

        public static MySingleton Instance
        {
            get 
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new MySingleton();
                    }
                    return instance;
                }
            }

        }
        public void loginLogic(BunifuMaterialTextbox Textbox1, BunifuMaterialTextbox Textbox2)
        {
            string uname = Textbox1.Text;
            string pass = Textbox2.Text;
            StreamReader sr = new StreamReader("login.txt");
            string data = sr.ReadToEnd();
            bool x = false;
            while (data != null)
            {
                if (data.Contains(uname + " " + pass))
                {
                    x = true;
                    Form1 ap = new Form1();
                    Environment.SetEnvironmentVariable("username", uname);
                    ap.Show();
                    //this.Hide();
                    break;
                }

                data = sr.ReadLine();
                
            }
            sr.Close();
            
            if (x == false)
            {
                MessageBox.Show("Invalid Username or Password");
                Textbox1.ResetText();
                Textbox2.ResetText();
            }
        }
       

        internal void loginLogic()
        {
            throw new NotImplementedException();
        }

        //internal void loginLogic(Bunifu.Framework.UI.BunifuMaterialTextbox Textbox1, Bunifu.Framework.UI.BunifuMaterialTextbox Textbox2)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
