using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Cafe_Management_Systems
{
    class Snacks : Items
    {
       public string ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }


        public void Add(BunifuMetroTextbox a, BunifuMetroTextbox b,BunifuMetroTextbox d, BunifuMetroTextbox e)
        {
            try
            {
                ID = a.Text;
                Name = b.Text;
                Quantity = Convert.ToInt32(d.Text);
                Price = Convert.ToInt32(e.Text);
         
                StreamReader sr = new StreamReader("product.txt");
                string data = sr.ReadToEnd();
                sr.Close();

                if (data.Contains(ID))
                {
                    MessageBox.Show("Product already exist");
                    a.ResetText();
                    b.ResetText();
                    d.ResetText();
                    e.ResetText();
                }
                else
                {
                    StreamWriter sw = new StreamWriter("product.txt", true);
                    sw.WriteLine(ID + "_" + Name +"_" + Quantity +"_" + Price);
                    sw.Close();
                    MessageBox.Show("Product Added");

                    a.ResetText();
                    b.ResetText();
                    d.ResetText();
                    e.ResetText();
                   
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        public void show(DataGridView dgv)
        {
            StreamReader sr = new StreamReader("product.txt", true);
            string line;
            string[] values = new string[4];
            dgv.ColumnCount = 4;
            while ((line = sr.ReadLine()) != null)
            {
                //dgv.Rows.Clear();
                for (int i = 0; i < values.Length; i++)
                {
                    values = line.Split('_');
                }

                dgv.Rows.Add(values);
            }
            
            sr.Close();


        }

    }
    }

