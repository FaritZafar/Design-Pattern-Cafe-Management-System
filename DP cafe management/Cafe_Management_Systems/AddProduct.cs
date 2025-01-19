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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void Textbox5_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ItemFactory fac = new ItemFactory();
                Items obj = fac.getInstance("Drinks");
                obj.ID = Textbox5.Text;
                obj.Name = Textbox1.Text;
                obj.Quantity = Convert.ToInt32(Textbox3.Text);
                obj.Price = Convert.ToInt32(Textbox4.Text);
                obj.Add(Textbox5, Textbox1, Textbox3, Textbox4);
                this.Hide();
                Form1 d = new Form1();
                d.Show();
                //StreamWriter sw = new StreamWriter("product.txt", true);
                //sw.WriteLine(obj.ID + "_" + obj.Name + "_" + obj.Quantity + "_" + obj.Price);
                //sw.Close();
                MessageBox.Show("ADDED SUCCESSFULLY");
               
               
            }
            else if (radioButton2.Checked)
            {
                ItemFactory fac = new ItemFactory();
                Items obj = fac.getInstance("Snacks");
                obj.ID = Textbox5.Text;
                obj.Name = Textbox1.Text;
                obj.Quantity = Convert.ToInt32(Textbox3.Text);
                obj.Price = Convert.ToInt32(Textbox4.Text);
                obj.Add(Textbox5, Textbox1, Textbox3, Textbox4);
                this.Hide();
                Form1 d = new Form1();
                d.Show();
                //StreamWriter sw = new StreamWriter("product.txt", true);
                //sw.WriteLine(obj.ID + "_" + obj.Name + "_" + obj.Quantity + "_" + obj.Price);
                //sw.Close();
                MessageBox.Show("ADDED SUCCESSFULLY");
            }
            else { MessageBox.Show("PLEASE SELECT TYPE"); }
         
        }
    }
}
